using System;
using System.Linq;

namespace AutoDocumentation {

    internal class StructDocumentation : TypeDocumentation {

        public StructDocumentation(Type pTypeDocumentation) : base(pTypeDocumentation) {
            DeclaredFields = pTypeDocumentation.GetFields().Select(field => new FieldDocumentation(field)).ToList();
            DeclaredConstructors = pTypeDocumentation
                .GetConstructors().Select(ctor => new ConstructorDocumentation(ctor)).ToList();
            DeclaredMethods = pTypeDocumentation.GetMethods().Select(method => new MethodDocumentation(method))
                                                .ToList();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1} {2} {3}",
                                 MarkdownFactory.Header(
                                                        2,
                                                        MarkdownFactory.FormatFullName(
                                                                                       Namespace,
                                                                                       Name,
                                                                                       ImplementedInterfaces,
                                                                                       BaseType),
                                                        MarkdownFactory.FormatAnchor(Name)),
                                 MarkdownFactory.FormatFields(DeclaredFields),
                                 MarkdownFactory.FormatConstructors(DeclaredConstructors),
                                 MarkdownFactory.FormatMethods(DeclaredMethods));
        }

    }

}