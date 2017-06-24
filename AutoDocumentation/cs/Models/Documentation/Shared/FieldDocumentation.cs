using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    public class FieldDocumentation : TypeDocumentation {

        private readonly string _type;
        private readonly List<Type> _typeArguments;

        public FieldDocumentation(FieldInfo pFieldInfo) : base(pFieldInfo) {
            _type = pFieldInfo.FieldType.Name;
            _typeArguments = pFieldInfo.FieldType.GenericTypeArguments.ToList();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1} {2} {3} {4}",
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatAccessModifier(
                                                                                                     IsPublic,
                                                                                                     IsPrivate)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatStaticModifier(IsStatic)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatAbstractModifier(IsAbstract)),
                                 MarkdownFactory
                                     .FormatBoldFont(
                                                     MarkdownFactory.FormatType(_type, _typeArguments)),
                                 Name);
        }

    }

}