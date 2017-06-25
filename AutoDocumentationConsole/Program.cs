namespace AutoDocumentationConsole {

    internal static class Program {

        public static void Main(string[] args) {
            const string path =
                @"C:\Users\Charles\RiderProjects\AutoDocumentation\DemoLibrary\bin\Debug\DemoLibrary.dll";
            AutoDocumentation.AutoDocumentation.GenerateDocumentation(path);
        }

    }

}