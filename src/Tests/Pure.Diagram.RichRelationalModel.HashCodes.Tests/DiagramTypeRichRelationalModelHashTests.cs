using System.Collections;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RichRelationalModel.HashCodes.Tests;

public sealed record DiagramTypeRichRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
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

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IDiagramTypeRichRelationalModel model = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );

        DiagramTypeRichRelationalModelHash expected = new DiagramTypeRichRelationalModelHash(model);
        DiagramTypeRichRelationalModelHash actual = new DiagramTypeRichRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdAndName()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash expected = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        DiagramTypeRichRelationalModelHash actual = new DiagramTypeRichRelationalModelHash(id, name);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashAndName()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash expected = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        DiagramTypeRichRelationalModelHash actual = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            name
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdAndNameHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash expected = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        DiagramTypeRichRelationalModelHash actual = new DiagramTypeRichRelationalModelHash(
            id,
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashAndNameHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash expected = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        DiagramTypeRichRelationalModelHash actual = new DiagramTypeRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash hash = new DiagramTypeRichRelationalModelHash(id, name);

        IEnumerable hashEnumerable = hash;
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(name))
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        DiagramTypeRichRelationalModelHash hash = new DiagramTypeRichRelationalModelHash(id, name);

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(name))
        );

        Assert.Equal(expectedHash, hash);
    }
}
