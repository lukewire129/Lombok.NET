﻿using Lombok.NET.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Lombok.NET.ConstructorGenerators
{
	/// <summary>
	/// Generates a constructor which takes all of the members as arguments.
	/// An all-arguments constructor is basically just a required-arguments constructor where all the members are required.
	/// </summary>
	[Generator]
	public class AllArgsConstructorGenerator : RequiredArgsConstructorGenerator
	{
		protected override string AttributeName { get; } = "AllArgsConstructor";

		protected override bool IsPropertyRequired(PropertyDeclarationSyntax p)
		{
			return true;
		}

		protected override bool IsFieldRequired(FieldDeclarationSyntax f)
		{
			return true;
		}

		protected override INamedTypeSymbol GetAttributeSymbol(SemanticModel model)
		{
			return SymbolCache.AllArgsConstructorAttributeSymbol ??= model.Compilation.GetSymbolByType<AllArgsConstructorAttribute>();
		}
	}
}