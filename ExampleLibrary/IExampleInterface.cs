using System;
using System.Collections.Generic;

namespace AutoDocumentationConsole {

    public interface IExampleInterface {

        void Print(string pText);

        void Store(string pText, string tag = null);

        void Store(ExampleStruct pText, string tag = null);

        Dictionary<Tuple<string, string, int, bool>, List<string>> GetComplexExample(
            List<string> pListString, Tuple<Dictionary<string, bool>, bool, bool, int> pTuple);
        
        ExampleStruct Get(int pIndex);

    }

}