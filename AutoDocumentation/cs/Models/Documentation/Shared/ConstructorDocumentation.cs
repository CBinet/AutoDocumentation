using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    internal class ConstructorDocumentation : TypeDocumentation {

        private readonly List<ParameterDocumentation> _parameters;

        public ConstructorDocumentation(MethodBase pCtorInfo) : base(pCtorInfo) {
            _parameters = pCtorInfo.GetParameters().Select(param => new ParameterDocumentation(param))
                                            .ToList();
        }

        public override string ToMarkdown() {
            return string.Format(
                                 "{0} {1} {2}({3})",
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatAccessModifier(
                                                                                                     IsPublic,
                                                                                                     IsPrivate)),
                                 MarkdownFactory.FormatBoldFont(
                                                                MarkdownFactory.FormatStaticModifier(IsStatic)),
                                 MarkdownFactory.CleanParameter(Name),
                                 MarkdownFactory.FormatParameters(_parameters));
        }

    }

}