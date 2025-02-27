using System;
using System.Collections.Generic;

namespace StrawberryShake.Generators.Descriptors
{
    public class ServicesDescriptor
        : IServicesDescriptor
        , IHasNamespace
    {
        public ServicesDescriptor(
            string name,
            string ns,
            IClientDescriptor client,
            IReadOnlyCollection<IEnumDescriptor> enumTypes,
            IReadOnlyCollection<IResultParserDescriptor> resultParsers)
        {
            Name = name
                ?? throw new ArgumentNullException(nameof(name));
            Namespace = ns
                ?? throw new ArgumentNullException(nameof(ns));
            Client = client
                ?? throw new ArgumentNullException(nameof(client));
            EnumTypes = enumTypes
                ?? throw new ArgumentNullException(nameof(enumTypes));
            ResultParsers = resultParsers
                ?? throw new ArgumentNullException(nameof(resultParsers));
        }

        public string Name { get; }

        public string Namespace { get; }

        public IClientDescriptor Client { get; }

        public IReadOnlyCollection<IEnumDescriptor> EnumTypes { get; }

        public IReadOnlyCollection<IResultParserDescriptor> ResultParsers { get; }

        public IEnumerable<ICodeDescriptor> GetChildren()
        {
            yield break;
        }
    }
}
