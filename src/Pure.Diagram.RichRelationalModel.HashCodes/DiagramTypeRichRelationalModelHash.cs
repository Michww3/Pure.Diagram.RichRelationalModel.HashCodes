using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.HashCodes;

public sealed record DiagramTypeRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        146,
        26,
        157,
        1,
        106,
        130,
        55,
        114,
        177,
        136,
        86,
        91,
        44,
        199,
        25,
        89,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _nameHash;

    public DiagramTypeRichRelationalModelHash(IDiagramTypeRichRelationalModel model)
        : this(model.Id, (model as IDiagramTypeRelationalModel).Name) { }

    public DiagramTypeRichRelationalModelHash(IGuid id, IString name)
        : this(new DeterminedHash(id), new DeterminedHash(name)) { }

    public DiagramTypeRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash nameHash
    )
    {
        _idHash = idHash;
        _nameHash = nameHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_nameHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
