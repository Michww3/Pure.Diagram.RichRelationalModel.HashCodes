using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.HashCodes;

public sealed record SeriesRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        148,
        26,
        157,
        1,
        61,
        231,
        240,
        121,
        184,
        126,
        28,
        232,
        138,
        37,
        101,
        163,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _diagramIdHash;

    private readonly IDeterminedHash _labelHash;

    private readonly IDeterminedHash _sourceHash;

    public SeriesRichRelationalModelHash(ISeriesRichRelationalModel model)
        : this(
            model.Id,
            model.DiagramId,
            (model as ISeriesRelationalModel).Label,
            (model as ISeriesRelationalModel).Source
        )
    { }

    public SeriesRichRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IString label,
        IString source
    )
        : this(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            new DeterminedHash(source)
        )
    { }

    public SeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
    {
        _idHash = idHash;
        _diagramIdHash = diagramIdHash;
        _labelHash = labelHash;
        _sourceHash = sourceHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_diagramIdHash)
                .Concat(_labelHash)
                .Concat(_sourceHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
