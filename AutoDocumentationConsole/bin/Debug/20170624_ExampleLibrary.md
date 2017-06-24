<h1>ExampleLibrary</h1> <h2 id='ExampleAbstractClassAnchor'>AutoDocumentationConsole.ExampleAbstractClass</h2>  <h3>Constructors : </h3><strong>protected</strong> <strong></strong> ExampleAbstractClass()<br> 
 <h3>Methods : </h3><strong>protected</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Capture(<strong>String[]</strong> pTextLines)<br> 
<hr><h2 id='ExampleClassAnchor'>AutoDocumentationConsole.ExampleClass : <a href='#IExampleInterfaceAnchor'>IExampleInterface</a>, IList, ICollection, IEnumerable, IEnumerable</h2> <h3>Fields : </h3><strong>private</strong> <strong></strong> <strong></strong> <strong>List&lt;<a href='#ExampleStructAnchor'>ExampleStruct</a>&gt;</strong> exampleStructs<br> 
<strong>protected</strong> <strong></strong> <strong></strong> <strong>Dictionary&lt;String, <a href='#ExampleStructAnchor'>ExampleStruct</a>&gt;</strong> exampleDict<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> ExampleClass(<strong>String</strong> pText)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Print(<strong>String</strong> pText)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Store(<strong>String</strong> pText, <strong>String</strong> tag = null)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Store(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> pText, <strong>String</strong> tag = null)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Dictionary&lt;Tuple&lt;String, String, Int32, Boolean&gt;, List&lt;String&gt;&gt;</strong> GetComplexExample(<strong>List&lt;String&gt;</strong> pListString, <strong>Tuple&lt;Dictionary&lt;String, Boolean&gt;, Boolean, Boolean, Int32&gt;</strong> pTuple)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> Get(<strong>Int32</strong> pIndex)<br> 
<strong>private</strong> <strong></strong> <strong></strong> <strong>Double</strong> Calculus(<strong>Int32</strong> a, <strong>Int32</strong> b, <strong>Single</strong> speed = 10, <strong>String</strong> method = quick)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>IEnumerator&lt;<a href='#ExampleStructAnchor'>ExampleStruct</a>&gt;</strong> GetEnumerator()<br> 
<strong>private</strong> <strong></strong> <strong></strong> <strong>IEnumerator</strong> System.Collections.IEnumerable.GetEnumerator()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Add(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> item)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Clear()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Boolean</strong> Contains(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> item)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> CopyTo(<strong>ExampleStruct[]</strong> array, <strong>Int32</strong> arrayIndex)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Boolean</strong> Remove(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> item)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> get_Count()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Boolean</strong> get_IsReadOnly()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> IndexOf(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> item)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Insert(<strong>Int32</strong> index, <strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> item)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> RemoveAt(<strong>Int32</strong> index)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> get_Item(<strong>Int32</strong> index)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> set_Item(<strong>Int32</strong> index, <strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> value)<br> 
<hr><h2 id='ExampleEnumAnchor'>AutoDocumentationConsole.ExampleEnum</h2> <h4>Values : </h4>0 : <strong>Red</strong>, <br> 
1 : <strong>Blue</strong>, <br> 
2 : <strong>Yellow</strong>, <br> 
3 : <strong>Green</strong><br> 
<hr><h2 id='ExampleStructAnchor'>AutoDocumentationConsole.ExampleStruct : ValueType</h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> Text<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> Length<br> 
  <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Boolean</strong> Equals(<strong>Object</strong> obj)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> GetHashCode()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> ToString()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Type</strong> GetType()<br> 
<hr><h2 id='IExampleInterfaceAnchor'>AutoDocumentationConsole.IExampleInterface : </h2>   <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Print(<strong>String</strong> pText)<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Store(<strong>String</strong> pText, <strong>String</strong> tag = null)<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Store(<strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> pText, <strong>String</strong> tag = null)<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Dictionary&lt;Tuple&lt;String, String, Int32, Boolean&gt;, List&lt;String&gt;&gt;</strong> GetComplexExample(<strong>List&lt;String&gt;</strong> pListString, <strong>Tuple&lt;Dictionary&lt;String, Boolean&gt;, Boolean, Boolean, Int32&gt;</strong> pTuple)<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong><a href='#ExampleStructAnchor'>ExampleStruct</a></strong> Get(<strong>Int32</strong> pIndex)<br> 
<hr><h2 id='ExampleStaticClassAnchor'>AutoDocumentationConsole.ExampleStaticClass</h2>   <h3>Methods : </h3><strong>public</strong> <strong>static</strong> <strong></strong> <strong><a href='#ExampleEnumAnchor'>ExampleEnum</a></strong> RandomColor()<br> 
<strong>public</strong> <strong>static</strong> <strong></strong> <strong>Int32</strong> RandomNumber(<strong>Int32</strong> min = 0, <strong>Int32</strong> max = 100)<br> 
<hr>