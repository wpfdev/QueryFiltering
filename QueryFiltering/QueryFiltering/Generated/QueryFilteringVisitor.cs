//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from QueryFiltering.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="QueryFilteringParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IQueryFilteringVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery([NotNull] QueryFilteringParser.QueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.queryParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQueryParameter([NotNull] QueryFilteringParser.QueryParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.top"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTop([NotNull] QueryFilteringParser.TopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.skip"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkip([NotNull] QueryFilteringParser.SkipContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.orderBy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderBy([NotNull] QueryFilteringParser.OrderByContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.orderByExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderByExpression([NotNull] QueryFilteringParser.OrderByExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.orderByAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderByAtom([NotNull] QueryFilteringParser.OrderByAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect([NotNull] QueryFilteringParser.SelectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.selectExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectExpression([NotNull] QueryFilteringParser.SelectExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilter([NotNull] QueryFilteringParser.FilterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.filterExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilterExpression([NotNull] QueryFilteringParser.FilterExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.filterAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilterAtom([NotNull] QueryFilteringParser.FilterAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExpression([NotNull] QueryFilteringParser.BoolExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] QueryFilteringParser.AtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperty([NotNull] QueryFilteringParser.PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] QueryFilteringParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryFilteringParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] QueryFilteringParser.FunctionContext context);
}
