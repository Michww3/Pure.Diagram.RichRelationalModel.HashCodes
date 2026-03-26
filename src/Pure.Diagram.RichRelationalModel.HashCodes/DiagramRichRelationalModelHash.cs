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
            title,
            description,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeId,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeId,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeId,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            description,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeIdHash,
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            new DeterminedHash(typeId),
            type,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeId,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            title,
            descriptionHash,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            new DeterminedHash(typeId),
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            description,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeIdHash,
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            new DeterminedHash(typeId),
            typeHash,
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            typeIdHash,
            new DiagramTypeHash(type),
            series
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeIdHash,
            type,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            description,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            new DeterminedHash(title),
            descriptionHash,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            new DeterminedHash(description),
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IEnumerable<ISeries> series
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            typeIdHash,
            typeHash,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDiagramType type,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            typeIdHash,
            new DiagramTypeHash(type),
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            new DeterminedHash(id),
            titleHash,
            descriptionHash,
            typeIdHash,
            typeHash,
            seriesHash
        )
    { }

    public DiagramRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId,
        IDeterminedHash typeHash,
        IDeterminedHash seriesHash
    )
        : this(
            idHash,
            titleHash,
            descriptionHash,
            new DeterminedHash(typeId),
            typeHash,
            seriesHash
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
