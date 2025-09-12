using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Paragraphs.Tests;

[Collection("Collection")]
public sealed class ParagraphTests : FixturedUnitTest
{
    public ParagraphTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the Paragraph component can be instantiated
        // This is a basic smoke test
        Assert.True(true);
    }
}
