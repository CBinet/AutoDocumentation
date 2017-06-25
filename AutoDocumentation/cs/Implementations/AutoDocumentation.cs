using System;
using System.IO;
using System.Reflection;
using AutoDocumentation;

namespace BetaSoftware {

    public static class AutoDocumentation {

        public static void GenerateDocumentation(string pPathToDll, string pFileName = null) {
            Assembly assembly = Assembly.LoadFrom(pPathToDll);
            if (pFileName == null) {
                pFileName = GenerateFilename(assembly.GetName().Name);
            }
            _GenerateDocumentation(assembly, pFileName);
        }

        public static void GenerateDocumentation(Assembly pAssembly, string pFileName = null) {
            if (pFileName == null) {
                pFileName = GenerateFilename(pAssembly.GetName().Name);
            }
            _GenerateDocumentation(pAssembly, pFileName);
        }

        #region private methods

        private static void _GenerateDocumentation(Assembly pAssembly, string pFileName) {
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