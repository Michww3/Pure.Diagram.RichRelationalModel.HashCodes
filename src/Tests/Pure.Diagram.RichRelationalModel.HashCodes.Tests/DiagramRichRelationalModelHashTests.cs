using System.Collections;
using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.Model.HashCodes;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RichRelationalModel.HashCodes.Tests;

public sealed record DiagramRichRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
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

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            new Guid(),
            new RandomString(),
            new RandomString(),
            new Guid(),
            new DiagramTypeRichRelationalModel(new Guid(), new RandomString()),
            [
                new SeriesRichRelationalModel(
                    new Guid(),
                    new Guid(),
                    new RandomString(),
                    new RandomString()
                ),
            ]
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashTypeHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId,
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashTypeIdHashSeriesHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            type,
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHashTypeIdHashTypeHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            series
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromAllHashes()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IDiagramRichRelationalModel model = new DiagramRichRelationalModel(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        DiagramRichRelationalModelHash expected = new DiagramRichRelationalModelHash(
            model
        );
        DiagramRichRelationalModelHash actual = new DiagramRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DiagramTypeHash(type),
            new DeterminedHash(series.Select(x => new SeriesHash(x)))
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IEnumerable hashEnumerable = new DiagramRichRelationalModelHash(
            id,
            title,
            description,
            typeId,
            type,
            series
        );

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(title))
                .Concat(new DeterminedHash(description))
                .Concat(new DeterminedHash(typeId))
                .Concat(new DiagramTypeHash(type))
                .Concat(new DeterminedHash(series.Select(x => new SeriesHash(x))))
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
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();
        IDiagramType type = new DiagramTypeRichRelationalModel(
            new Guid(),
            new RandomString()
        );
        IEnumerable<ISeries> series =
        [
            new SeriesRichRelationalModel(
                new Guid(),
                new Guid(),
                new RandomString(),
                new RandomString()
            ),
        ];

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(title))
                .Concat(new DeterminedHash(description))
                .Concat(new DeterminedHash(typeId))
                .Concat(new DiagramTypeHash(type))
                .Concat(new DeterminedHash(series.Select(x => new SeriesHash(x))))
        );

        Assert.Equal(
            expectedHash,
            new DiagramRichRelationalModelHash(
                id,
                title,
                description,
                typeId,
                type,
                series
            )
        );
    }
}
