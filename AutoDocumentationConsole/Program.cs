namespace AutoDocumentationConsole {

    internal static class Program {

        public static void Main(string[] args) {
            const string path =
                @"C:\Users\Charles\Documents\VisualStudio2015\Projects\Beta\Beta\bin\Debug\Beta.dll";
            AutoDocumentation.AutoDocumentation.GenerateDocumentation(path);
        }

    }

}