using System;
using HotChocolate.Language;
using HotChocolate.Types;

namespace HotChocolate.Stitching.Utilities
{
    public sealed class CustomScalarType
        : ScalarType
    {
        public CustomScalarType(ScalarTypeDefinitionNode typeDefinition)
            : base(typeDefinition?.Name.Value)
        {
            Description = typeDefinition?.Description?.Value;
            SyntaxNode = typeDefinition;
        }

        public override Type ClrType => typeof(object);

        public ScalarTypeDefinitionNode SyntaxNode { get; }

        public override bool IsInstanceOfType(IValueNode literal)
        {
            throw new NotSupportedException();
        }

        public override object ParseLiteral(IValueNode literal)
        {
            throw new NotSupportedException();
        }

        public override IValueNode ParseValue(object value)
        {
            throw new NotSupportedException();
        }

        public override object Serialize(object value)
        {
            throw new NotSupportedException();
        }

        public override bool TryDeserialize(object serialized, out object value)
        {
            throw new NotSupportedException();
        }
    }
}
