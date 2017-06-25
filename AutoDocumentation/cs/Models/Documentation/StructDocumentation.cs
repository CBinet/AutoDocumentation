using System;
using System.Linq;

namespace AutoDocumentation {

    internal class StructDocumentation : TypeDocumentation {

        public StructDocumentation(Type pTypeInfo) : base(pTypeInfo) {
            DeclaredFields = pTypeInfo.GetFields().Select(field => new FieldDocumentation(field)).ToList();
            DeclaredConstructors = pTypeInfo
                .GetConstructors().Select(ctor => new ConstructorDocumentation(ctor)).ToList();
            DeclaredMethods = pTypeInfo.GetMethods().Select(method => new MethodDocumentation(method))
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
                                                                                       TypeArguments,
                                                                                       ImplementedInterfaces,
                                                                                       BaseType),
                                                        MarkdownFactory.FormatAnchor(Name)),
                                 MarkdownFactory.FormatFields(DeclaredFields),
                                 MarkdownFactory.FormatConstructors(DeclaredConstructors),
                                 MarkdownFactory.FormatMethods(DeclaredMethods));
        }

    }

}