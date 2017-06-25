using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    internal class ParameterDocumentation {

        private readonly string _type;
        private readonly string _name;
        private readonly string _defaultValue;
        private readonly List<Type> _typeArguments;

        public ParameterDocumentation(ParameterInfo parameterInfo) {
            _type = parameterInfo.ParameterType.Name;
            _typeArguments = parameterInfo.ParameterType.GenericTypeArguments.ToList();
            _name = parameterInfo.Name;
            _defaultValue = parameterInfo.DefaultValue != null ? parameterInfo.DefaultValue.ToString() : "null";
        }

        public string ToMarkdown() {
            return string.Format(
                                 "{0} {1}{2}",
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.Anchor(
                                                                                       _type + "Anchor",
                                                                                       MarkdownFactory.FormatType(
                                                                                                                  _type,
                                                                                                                  _typeArguments))),
                                 _name,
                                 MarkdownFactory.FormatDefaultValue(_defaultValue));
        }

    }

}