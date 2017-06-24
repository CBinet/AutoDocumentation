using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    public class MethodDocumentation : TypeDocumentation {

        private readonly string _returnParameter;
        private readonly List<Type> _returnParameterArguments;
        private readonly List<ParameterDocumentation> _parameters;

        public MethodDocumentation(MethodInfo pMethodDocumentation) : base(pMethodDocumentation) {
            _returnParameter = pMethodDocumentation.ReturnType.Name;
            _returnParameterArguments = pMethodDocumentation.ReturnType.GenericTypeArguments.ToList();
            _parameters = pMethodDocumentation.GetParameters().Select(param => new ParameterDocumentation(param))
                                              .ToList();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1} {2} {3} {4}({5})",
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatAccessModifier(
                                                                                                     IsPublic,
                                                                                                     IsPrivate)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatStaticModifier(IsStatic)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatAbstractModifier(IsAbstract)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.Anchor(
                                                                                       _returnParameter + "Anchor",
                                                                                       MarkdownFactory.FormatType(
                                                                                                                  _returnParameter,
                                                                                                                  _returnParameterArguments))),
                                 Name,
                                 MarkdownFactory.FormatParameters(_parameters));
        }

    }

}