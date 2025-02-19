// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Generator.CSharp.Expressions;

namespace Microsoft.Generator.CSharp.Snippets
{
    public record IndexableExpression(ValueExpression Inner) : ValueExpression
    {
        public IndexableExpression(CSharpType type, string name) : this(new VariableExpression(type, name))
        {
        }

        public ValueExpression this[ValueExpression index] => new IndexerExpression(this, index);

        internal override void Write(CodeWriter writer)
        {
            Inner.Write(writer);
        }
    }
}
