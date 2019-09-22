using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._1___Settler
{
    [TestClass]
    public sealed class TEST_Tests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.TEST;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"1
2
88
42
99",
@"13
25
42",
@"42
12",
@"hello
stuff
42"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"1
2
88
",
@"13
25
",
"",
@"hello
stuff
"
        };

        [TestMethod]
        public void TEST() => TestSolution();
    }
}