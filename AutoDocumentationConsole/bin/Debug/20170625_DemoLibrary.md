<h1>DemoLibrary</h1> <h2 id='AddressAnchor'>DemoLibrary.Address : <a href='#IFormattableAnchor'>IFormattable</a></h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> DoorNumber<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> StreetName<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> City<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> PostalCode<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> Address(<strong>Int32</strong> doorNumber, <strong>String</strong> streetName, <strong>String</strong> city, <strong>String</strong> postalCode)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> GetFormattedInformations()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Format()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Boolean</strong> Equals(<strong>Object</strong> obj)<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> GetHashCode()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> ToString()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Type</strong> GetType()<br> 
<hr><h2 id='DepartmentAnchor'>DemoLibrary.Department</h2> <h4>Values : </h4>0 : <strong>Sales</strong>, <br> 
1 : <strong>Marketing</strong>, <br> 
2 : <strong>HumanResources</strong><br> 
<hr><h2 id='EmployeeAnchor'>DemoLibrary.Employee : <a href='#IFormattableAnchor'>IFormattable</a></h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> Id<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> Name<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong><a href='#AddressAnchor'>Address</a></strong> Address<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong><a href='#DepartmentAnchor'>Department</a></strong> Department<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> Employee(<strong>Int32</strong> pId, <strong>String</strong> pName, <strong><a href='#AddressAnchor'>Address</a></strong> address, <strong><a href='#DepartmentAnchor'>Department</a></strong> department)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> GetFormattedInformations()<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>Void</strong> Format()<br> 
<hr><h2 id='IFormattableAnchor'>DemoLibrary.IFormattable : </h2>   <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>String</strong> GetFormattedInformations()<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Format()<br> 
<hr>