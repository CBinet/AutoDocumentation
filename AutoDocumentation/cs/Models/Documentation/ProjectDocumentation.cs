using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoDocumentation {

    public class ProjectDocumentation {

        private readonly Assembly _assembly;
        private readonly IList<TypeDocumentation> _definedTypes;

        public ProjectDocumentation(Assembly pAssembly) {
            _assembly = pAssembly;
            _definedTypes = FilterDefinedTypes(pAssembly.DefinedTypes).Select(TypeDocumentationFactory.Create).ToList();
            MarkdownFactory.DefinedTypes = _definedTypes;
        }

        public string ToMarkdown() {
            return string.Format("{0} {1}", MarkdownFactory.Header(1, _assembly.GetName().Name), FormatDefinedTypes());
        }

        private string FormatDefinedTypes() {
            StringBuilder sb = new StringBuilder();
            foreach (TypeDocumentation definedType in _definedTypes) {
                sb.Append(definedType.ToMarkdown());
                sb.Append(MarkdownFactory.Separator());
            }
            return sb.ToString();
        }

        private IEnumerable<TypeInfo> FilterDefinedTypes(IEnumerable<TypeInfo> pDefinedTypes) {
            return pDefinedTypes.Where(type => type.GetCustomAttribute<AutoDocumentationIgnore>() == null && !type.Name.Contains("<"));
        }

    }



}