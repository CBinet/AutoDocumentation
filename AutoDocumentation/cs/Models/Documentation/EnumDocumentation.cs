using System;

namespace AutoDocumentation {

    internal class EnumDocumentation : TypeDocumentation {

        public EnumDocumentation(Type pTypeInfo) : base(pTypeInfo) {
            Enums = pTypeInfo.GetEnumNames();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1}",
                                 MarkdownFactory.Header(2, FullName, MarkdownFactory.FormatAnchor(Name)),
                                 MarkdownFactory.FormatEnums(Enums));
        }

        

    }

}