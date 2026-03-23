using System.Collections;
using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.Model.HashCodes;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.HashCodes;

public sealed record DiagramRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        145,
        26,
        157,
        1,
        93,
        14,
        215,
        125,
        153,
        111,
        213,
        83,
        49,
        8,
        227,
        105,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _titleHash;

    private readonly IDeterminedHash _descriptionHash;

    private readonly IDeterminedHash _typeIdHash;

    private readonly IDeterminedHash _typeHash;

    private readonly IDeterminedHash _seriesHash;

    public DiagramRichRelationalModelHash(IDiagramRichRelationalModel model)
        : this(
            model.Id,
            (model as IDiagramRelationalModel).Title,
            (model as IDiagramRelationalModel).Description,
            model.TypeId,
            model.Type,
            model.Series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
    {
        _idHash = idHash;
        _titleHash = titleHash;
        _descriptionHash = descriptionHash;
        _typeIdHash = typeIdHash;
        _typeHash = typeHash;
        _seriesHash = seriesHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_titleHash)
                .Concat(_descriptionHash)
                .Concat(_typeIdHash)
                .Concat(_typeHash)
                .Concat(_seriesHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
