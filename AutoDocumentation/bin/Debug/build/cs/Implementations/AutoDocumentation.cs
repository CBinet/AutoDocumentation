using System;
using System.IO;
using System.Reflection;

namespace AutoDocumentation {

    public static class AutoDocumentation {

        public static void GenerateDocumentation(string pPathToDll, bool pOnlyPublicTypes = true, string pFileName = null) {
            Assembly assembly = Assembly.LoadFrom(pPathToDll);
            if (pFileName == null) {
                pFileName = GenerateFilename(assembly.GetName().Name);
            }
            _GenerateDocumentation(assembly, pOnlyPublicTypes, pFileName);
        }

        public static void GenerateDocumentation(Assembly pAssembly, bool pOnlyPublicTypes = true, string pFileName = null) {
            if (pFileName == null) {
                pFileName = GenerateFilename(pAssembly.GetName().Name);
            }
            _GenerateDocumentation(pAssembly, pOnlyPublicTypes, pFileName);
        }

        #region private methods

        private static void _GenerateDocumentation(Assembly pAssembly, bool pOnlyPublicTypes, string pFileName) {
            ProjectDocumentation projectDocumentation = new ProjectDocumentation(pAssembly);
            File.WriteAllText(
                              Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pFileName),
                              projectDocumentation.ToMarkdown());
        }

        private static string GenerateFilename(string pName = null) {
            return string.Format("{0:yyyyMMdd}_{1}.md", DateTime.Now, pName ?? "Autodocumentation");
        }

        #endregion

    }

}