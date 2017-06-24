using System;

namespace AutoDocumentation {

    public class EnumDocumentation : TypeDocumentation {

        public EnumDocumentation(Type pTypeDocumentation) : base(pTypeDocumentation) {
            Enums = pTypeDocumentation.GetEnumNames();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1}",
                                 MarkdownFactory.Header(2, FullName, MarkdownFactory.FormatAnchor(Name)),
                                 MarkdownFactory.FormatEnums(Enums));
        }

        

    }

}