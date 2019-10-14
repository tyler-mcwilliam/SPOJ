using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._2___Chieftain
{
    [TestClass]
    public sealed class ARMY_Tests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.ARMY;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"3

1 1
1
1

3 2
1 3 2
5 5

2 3
5 5
1 1 1
"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"Godzilla
MechaGodzilla
Godzilla
"
        };

        [TestMethod]
        public void ARMY() => TestSolution();
    }
}