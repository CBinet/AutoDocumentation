using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    internal class ClassDocumentation : TypeDocumentation {

        public ClassDocumentation(TypeInfo pTypeInfo) : base(pTypeInfo) {
            DeclaredFields = pTypeInfo.DeclaredFields.Select(field => new FieldDocumentation(field)).ToList();
            DeclaredConstructors = pTypeInfo
                .DeclaredConstructors.Select(ctor => new ConstructorDocumentation(ctor)).ToList();
            DeclaredMethods = pTypeInfo.DeclaredMethods.Select(method => new MethodDocumentation(method))
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