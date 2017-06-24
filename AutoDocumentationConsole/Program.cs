namespace AutoDocumentationConsole {

    internal static class Program {

        public static void Main(string[] args) {
            const string path =
                @"C:\Users\Charles\RiderProjects\AutoDocumentation\ExampleLibrary\bin\Debug\ExampleLibrary.dll";
            AutoDocumentation.AutoDocumentation.GenerateDocumentation(path);
        }

    }

}