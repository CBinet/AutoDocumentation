using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoDocumentationConsole {

    public class ExampleClass : IExampleInterface, IList<ExampleStruct> {

        private List<ExampleStruct> exampleStructs;
        protected Dictionary<string, ExampleStruct> exampleDict;

        public ExampleClass(string pText) {
            Store(pText);
        }
        
        public void Print(string pText) {
            Console.WriteLine(pText);
        }

        public void Store(string pText, string tag = null) {
            exampleStructs.Add(new ExampleStruct() {Text = pText});
        }

        public void Store(ExampleStruct pText, string tag = null) {
            exampleStructs.Add(pText);
        }

        public Dictionary<Tuple<string, string, int, bool>, List<string>> GetComplexExample(List<string> pListString, Tuple<Dictionary<string, bool>, bool, bool, int> pTuple) {
            return new Dictionary<Tuple<string, string, int, bool>, List<string>>();
        }

        public ExampleStruct Get(int pIndex) {
            return exampleStructs[pIndex];
        }

        private double Calculus(int a, int b, float speed = 10, string method = "quick") {
            return 0.0;
        }

        public IEnumerator<ExampleStruct> GetEnumerator() {
            return exampleStructs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable) exampleStructs).GetEnumerator();
        }

        public void Add(ExampleStruct item) {
            exampleStructs.Add(item);
        }

        public void Clear() {
            exampleStructs.Clear();
        }

        public bool Contains(ExampleStruct item) {
            return exampleStructs.Contains(item);
        }

        public void CopyTo(ExampleStruct[] array, int arrayIndex) {
            exampleStructs.CopyTo(array, arrayIndex);
        }

        public bool Remove(ExampleStruct item) {
            return exampleStructs.Remove(item);
        }

        public int Count {
            get { return exampleStructs.Count; }
        }
        public bool IsReadOnly {
            get { return ((ICollection<ExampleStruct>) exampleStructs).IsReadOnly; }
        }

        public int IndexOf(ExampleStruct item) {
            return exampleStructs.IndexOf(item);
        }

        public void Insert(int index, ExampleStruct item) {
            exampleStructs.Insert(index, item);
        }

        public void RemoveAt(int index) {
            exampleStructs.RemoveAt(index);
        }

        public ExampleStruct this[int index] {
            get { return exampleStructs[index]; }
            set { exampleStructs[index] = value; }
        }

    }

}