﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spoj.Solver {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Solutions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Solutions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Spoj.Solver.Solutions", typeof(Solutions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Linq;
        ///
        ///// https://www.spoj.com/problems/ADDREV/
        ///// Returns the reversed sum of two reversed integers
        ///public static class ADDREV
        ///{
        ///    public static int Solve(int a, int b)
        ///        =&gt; Reverse(Reverse(a) + Reverse(b));
        ///
        ///    private static int Reverse(int a)
        ///        =&gt; int.Parse(new string(a.ToString().Reverse().ToArray()));
        ///}
        ///
        ///public static class Program
        ///{
        ///    private static void Main()
        ///    {
        ///        int remainingTestCases = int.Parse(Console.ReadLine());
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ADDREV {
            get {
                return ResourceManager.GetString("ADDREV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Linq;
        ///
        ///// https://www.spoj.com/problems/ARMY/
        ///// Determines the winner of a hypothetical battle
        ///// between the armies of Godzilla and MechaGodzilla.
        ///public static class ARMY
        ///{
        ///    public static string Solve(int[] godzillaStrengths, int[] mechaGodzillaStrengths)
        ///        =&gt; godzillaStrengths.Max() &gt;= mechaGodzillaStrengths.Max()
        ///        ? &quot;Godzilla&quot; : &quot;MechaGodzilla&quot;;
        ///}
        ///
        ///public static class Program
        ///{
        ///    private static void Main()
        ///    {
        ///        int remainingTestCase [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ARMY {
            get {
                return ResourceManager.GetString("ARMY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #ad-hoc
        ///#bfs
        ///#big-numbers
        ///#binary
        ///#binary-search
        ///#bit
        ///#bitmask
        ///#bst
        ///#buckets
        ///#combinatorics
        ///#compression
        ///#dag
        ///#deque
        ///#dfs
        ///#digits
        ///#dijkstras
        ///#disjoint-sets
        ///#divide-and-conquer
        ///#division
        ///#dynamic-programming
        ///#dynamic-programming-1d
        ///#dynamic-programming-2d
        ///#dynamic-programming-3d
        ///#euler-path
        ///#factorial
        ///#factors
        ///#formula
        ///#game
        ///#gcd
        ///#golf
        ///#graph-theory
        ///#greedy
        ///#hash-table
        ///#heap
        ///#hld
        ///#io
        ///#knapsack
        ///#lazy
        ///#lca
        ///#longest-path
        ///#math
        ///#memoization
        ///#merge
        ///#mod-math
        ///#mst
        ///#offl [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Tags {
            get {
                return ResourceManager.GetString("Tags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///// https://www.spoj.com/problems/TEST/
        ///// Reads and prints input until 42 is found.
        ///public static class TEST
        ///{
        ///    public static void Solve()
        ///    {
        ///        string line;
        ///        while ((line = Console.ReadLine()) != &quot;42&quot;)
        ///        {
        ///            Console.WriteLine(line);
        ///        }
        ///    }
        ///}
        ///
        ///public static class Program
        ///{
        ///    public static void Main()
        ///        =&gt; TEST.Solve();
        ///}.
        /// </summary>
        public static string TEST {
            get {
                return ResourceManager.GetString("TEST", resourceCulture);
            }
        }
    }
}
