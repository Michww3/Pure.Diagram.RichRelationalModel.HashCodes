using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RichRelationalModel.HashCodes.Tests;

public sealed record SeriesRichRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
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

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            model.DiagramId,
            (model as ISeriesRelationalModel).Label,
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            model.DiagramId,
            (model as ISeriesRelationalModel).Label,
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            new DeterminedHash(model.DiagramId),
            (model as ISeriesRelationalModel).Label,
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            model.DiagramId,
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            model.DiagramId,
            (model as ISeriesRelationalModel).Label,
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            new DeterminedHash(model.DiagramId),
            (model as ISeriesRelationalModel).Label,
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            model.DiagramId,
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHasSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            model.DiagramId,
            (model as ISeriesRelationalModel).Label,
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashLabelHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            new DeterminedHash(model.DiagramId),
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            new DeterminedHash(model.DiagramId),
            (model as ISeriesRelationalModel).Label,
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            model.DiagramId,
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHashLabelHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            new DeterminedHash(model.DiagramId),
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            (model as ISeriesRelationalModel).Source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            new DeterminedHash(model.DiagramId),
            (model as ISeriesRelationalModel).Label,
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);

        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            model.DiagramId,
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashLabelHashSourceHash()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);

        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            model.Id,
            new DeterminedHash(model.DiagramId),
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromAllHashes()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        SeriesRichRelationalModelHash expected = new SeriesRichRelationalModelHash(model);
        SeriesRichRelationalModelHash actual = new SeriesRichRelationalModelHash(
            new DeterminedHash(model.Id),
            new DeterminedHash(model.DiagramId),
            new DeterminedHash((model as ISeriesRelationalModel).Label),
            new DeterminedHash((model as ISeriesRelationalModel).Source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        IEnumerable hashEnumerable = new SeriesRichRelationalModelHash(model);
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(new DeterminedHash((model as ISeriesRelationalModel).Label))
                .Concat(new DeterminedHash((model as ISeriesRelationalModel).Source))
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
        ISeriesRichRelationalModel model = new SeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(new DeterminedHash((model as ISeriesRelationalModel).Label))
                .Concat(new DeterminedHash((model as ISeriesRelationalModel).Source))
        );

        Assert.Equal(expectedHash, new SeriesRichRelationalModelHash(model));
    }
}
