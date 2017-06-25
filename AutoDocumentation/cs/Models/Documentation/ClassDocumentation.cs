using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    internal class ClassDocumentation : TypeDocumentation {

        public ClassDocumentation(TypeInfo pTypeDocumentation) : base(pTypeDocumentation) {
            DeclaredFields = pTypeDocumentation.DeclaredFields.Select(field => new FieldDocumentation(field)).ToList();
            DeclaredConstructors = pTypeDocumentation
                .DeclaredConstructors.Select(ctor => new ConstructorDocumentation(ctor)).ToList();
            DeclaredMethods = pTypeDocumentation.DeclaredMethods.Select(method => new MethodDocumentation(method))
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