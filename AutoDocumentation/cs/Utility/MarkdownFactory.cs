using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoDocumentation {

    internal static class MarkdownFactory {

        public static IList<TypeDocumentation> DefinedTypes;

        public static string Header(int pSize, string pText, string pId = null) {
            return pId == null
                       ? string.Format("<h{0}>{1}</h{0}>", pSize, CleanParameter(pText))
                       : string.Format(
                                       "<h{0} id='{1}'>{2}</h{0}>",
                                       pSize,
                                       CleanParameter(pId),
                                       CleanParameter(pText));
        }

        public static string Anchor(string pHref, string pText) {
            var list = DefinedTypes.Select(type => type.GetName()).ToList();
            if (list.Contains(pText)) {
                return string.Format("<a href='#{0}'>{1}</a>", CleanParameter(pHref), CleanParameter(pText));
            }
            return CleanParameter(pText);
        }

        public static string Separator() {
            return "<hr>";
        }

        public static string FormatAnchor(string pName) {
            return pName + "Anchor";
        }

        public static string FormatAccessModifier(bool pIsPublic, bool pIsPrivate) {
            if (pIsPublic && !pIsPrivate) {
                return "public";
            } else if (!pIsPublic && pIsPrivate) {
                return "private";
            } else {
                return "protected";
            }
        }

        public static string FormatStaticModifier(bool pIsStatic) {
            return pIsStatic ? "static" : "";
        }

        public static string FormatAbstractModifier(bool pIsAbstract) {
            return pIsAbstract ? "abstract" : "";
        }

        public static string FormatFullName(string pNamespace, string pName, List<Type> pTypeArguments, IList<string> pImplementedInterfaces,
                                            string pBaseType) {
            if (pImplementedInterfaces?.Count > 0) {
                return pNamespace + "." + FormatType(pName, pTypeArguments) + FormatInterfaces(pImplementedInterfaces);
            }
            if (pBaseType != null) {
                return pNamespace + "." + FormatType(pName, pTypeArguments) + " : " + pBaseType;
            }
            return pNamespace + "." + FormatType(pName, pTypeArguments);
        }

        public static string FormatFields(IList<FieldDocumentation> declaredFields) {
            StringBuilder sb =
                new StringBuilder(
                                  declaredFields.Count > 0
                                      ? Header(3, "Fields : ")
                                      : "");
            foreach (FieldDocumentation field in declaredFields) {
                sb.Append(field.ToMarkdown());
                sb.Append(NewLine());
            }
            return sb.ToString();
        }

        public static string FormatConstructors(IList<ConstructorDocumentation> declaredConstructors) {
            StringBuilder sb =
                new StringBuilder(
                                  declaredConstructors.Count > 0
                                      ? Header(3, "Constructors : ")
                                      : "");
            foreach (ConstructorDocumentation ctor in declaredConstructors) {
                sb.Append(ctor.ToMarkdown());
                sb.Append(NewLine());
            }
            return sb.ToString();
        }

        public static string FormatMethods(IList<MethodDocumentation> declaredMethods) {
            StringBuilder sb =
                new StringBuilder(
                                  declaredMethods.Count > 0
                                      ? Header(3, "Methods : ")
                                      : "");
            foreach (MethodDocumentation method in declaredMethods) {
                sb.Append(method.ToMarkdown());
                sb.Append(NewLine());
            }
            return sb.ToString();
        }

        public static string FormatParameters(List<ParameterDocumentation> pParameters) {
            StringBuilder sb = new StringBuilder();
            foreach (ParameterDocumentation parameter in pParameters) {
                sb.Append(parameter.ToMarkdown());
                if (!pParameters.Last().Equals(parameter)) {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        public static string FormatType(string pType, List<Type> pTypeArguments) {
            if (pTypeArguments.Count > 0) {
                return string.Format("{0}&lt;{1}&gt;", FormatFieldName(pType), FormatTypes(pTypeArguments));
            } else {
                return string.Format("{0}", FormatFieldName(pType));
            }
        }

        private static string FormatFieldName(string pFieldTypeName) {
            return Anchor(CleanParameter(pFieldTypeName) + "Anchor", CleanParameter(pFieldTypeName));
        }

        private static string FormatTypes(List<Type> pTypes) {
            StringBuilder sb = new StringBuilder();
            foreach (Type type in pTypes) {
                sb.Append(Anchor(type.Name + "Anchor", FormatType(type.Name, type.GenericTypeArguments.ToList())));
                if (!(pTypes.Last() == type)) {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        public static string FormatEnums(string[] pEnums) {
            StringBuilder sb = new StringBuilder(Header(4, "Values : "));
            int count = 0;
            foreach (var enm in pEnums) {
                sb.Append(string.Format("{0} : {1}", count++, FormatBoldFont(enm)));
                if (pEnums.Last() != enm) {
                    sb.Append(", ");
                }
                sb.Append(NewLine());
            }
            return sb.ToString();
        }

        public static string FormatDefaultValue(object pDefaultValue) {
            return pDefaultValue == "" ? "" : " = " + pDefaultValue;
        }

        public static string FormatColorFont(string pColor, string pText) {
            return string.Format("<font color = '{0}' >{1}</font >", pColor, pText);
        }

        public static string FormatBoldFont(string pText) {
            return string.Format("<strong>{0}</strong>", pText);
        }

        private static string NewLine() {
            return "<br> \r\n";
        }

        private static string FormatInterfaces(IList<string> pImplementedInterfaces) {
            StringBuilder sb = new StringBuilder();
            foreach (var implementedInterface in pImplementedInterfaces) {
                if (pImplementedInterfaces.First().Equals(implementedInterface)) {
                    sb.Append(" : ");
                }
                sb.Append(Anchor(implementedInterface + "Anchor", implementedInterface));
                if (!pImplementedInterfaces.Last().Equals(implementedInterface)) {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        public static string CleanParameter(string returnParameter) {
            return returnParameter.Split('`')[0];
        }

    }

}