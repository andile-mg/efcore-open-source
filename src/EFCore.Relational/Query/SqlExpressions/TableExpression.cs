// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.EntityFrameworkCore.Query.SqlExpressions;

/// <summary>
///     An expression that represents a table or view in a SQL tree.
/// </summary>
/// <remarks>
///     This is a simple wrapper around a table and schema name. Instances of this type cannot be constructed by
///     application or database provider code. If this is a problem for your application or provider, then please file
///     an issue at <see href="https://github.com/dotnet/efcore">github.com/dotnet/efcore</see>.
/// </remarks>
public sealed class TableExpression : TableExpressionBase, ITableBasedExpression
{
    internal TableExpression(string alias, ITableBase table)
        : this(alias, table, annotations: null)
    {
    }

    private TableExpression(string alias, ITableBase table, IReadOnlyDictionary<string, IAnnotation>? annotations)
        : base(alias, annotations)
    {
        Name = table.Name;
        Schema = table.Schema;
        Table = table;
    }

    /// <summary>
    ///     The alias assigned to this table source.
    /// </summary>
    public override string Alias
        => base.Alias!;

    /// <summary>
    ///     The name of the table or view.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The schema of the table or view.
    /// </summary>
    public string? Schema { get; }

    /// <summary>
    ///     The <see cref="ITableBase" /> associated with this table or view.
    /// </summary>
    public ITableBase Table { get; }

    /// <inheritdoc />
    ITableBase ITableBasedExpression.Table
        => Table;

    /// <inheritdoc />
    protected override void Print(ExpressionPrinter expressionPrinter)
    {
        if (!string.IsNullOrEmpty(Schema))
        {
            expressionPrinter.Append(Schema).Append(".");
        }

        expressionPrinter.Append(Name);
        PrintAnnotations(expressionPrinter);

        expressionPrinter.Append(" AS ").Append(Alias);
    }

    /// <inheritdoc />
    public override TableExpressionBase Clone(string? alias, ExpressionVisitor cloningExpressionVisitor)
        => new TableExpression(alias!, Table, Annotations);

    /// <inheritdoc />
    protected override TableExpression WithAnnotations(IReadOnlyDictionary<string, IAnnotation> annotations)
        => new(Alias, Table, annotations);

    /// <inheritdoc />
    public override TableExpression WithAlias(string newAlias)
        => new(newAlias, Table, Annotations);

    /// <inheritdoc />
    public override bool Equals(object? obj)
        => obj != null
            && (ReferenceEquals(this, obj)
                || obj is TableExpression fromSqlExpression
                && Equals(fromSqlExpression));

    private bool Equals(TableExpression fromSqlExpression)
        => base.Equals(fromSqlExpression)
            && Table == fromSqlExpression.Table;

    /// <inheritdoc />
    public override int GetHashCode()
        => HashCode.Combine(base.GetHashCode(), Name, Schema);
}
