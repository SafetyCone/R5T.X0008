using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Instances = R5T.X0008.Instances;


namespace R5T.N0001.Composition.Addition.Simple.Unannotated
{
    public static class CompilationUnitSyntaxExtensions
    {
        public static CompilationUnitSyntax AddUsingDirective(this CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective)
        {
            var output = Instances.SyntaxOperator_AddSimple.AddUsingDirective(
                compilationUnit,
                usingDirective);

            return output;
        }

        public static CompilationUnitSyntax AddUsingDirectives(this CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax[] usingDirectives)
        {
            var output = compilationUnit.AddUsings(usingDirectives);
            return output;
        }

        public static CompilationUnitSyntax AddUsingDirectives(this CompilationUnitSyntax compilationUnit,
            IEnumerable<UsingDirectiveSyntax> usingDirectives)
        {
            var output = compilationUnit.AddUsingDirectives(usingDirectives.ToArray());
            return output;
        }
    }
}
