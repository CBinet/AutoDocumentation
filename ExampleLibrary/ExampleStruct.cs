using System.IO;
using Newtonsoft.Json;

namespace AutoDocumentationConsole {

    public struct ExampleStruct {

        public string Text;
        public int Length;

        private void Serialise(string pPath) {
            File.WriteAllText(pPath, JsonConvert.SerializeObject(this));
        }

    }

}