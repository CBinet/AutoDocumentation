# AutoDocumentation

## **Installation**
To install **AutoDocumentation**, you can either browse the Package Manager or run the following command in the <a href='#https://docs.microsoft.com/fr-fr/nuget/tools/package-manager-console'>Package Manager Console</a> :

```
PM> Install-Package BetaSoftware.AutoDocumentation
```

<br> <hr> <br>

## **Usage**
To start using **AutoDocumentation**, simply call the GenerateDocumentation method of the **AutoDocumentation** class with the project assembly :

```cs
var assembly = Assembly.LoadFrom(pathToDll); // Load the assembly.
BetaSoftware.AutoDocumentation.GenerateDocumentation(assembly);
```
To include all private and internal types in the generated documentation, call the GenerateDocumentation method with **false** as the second parameter :
```cs
var assembly = Assembly.LoadFrom(pathToDll); // Load the assembly.
BetaSoftware.AutoDocumentation.GenerateDocumentation(assembly, false);
```

### Settings attributes
You can customize the content that will appear in your generated documentation
with the **AutoDocumentation** attributes :

#### AutoDocumentationIgnore
Add to exclude a type from documentation generation : 

```cs
[AutoDocumentationIgnore]
public class IgnoredClass {
    ...
}
```

<br> <hr> <br>

## **Examples : Interface documentation**

```cs
namespace DemoLibrary {

    public interface IFormattable {

        string FormatInformations();

    }

}
```

<h2 id='IFormattableAnchor'>DemoLibrary.IFormattable </h2>   <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>String</strong> FormatInformations()<br>

<br> <hr> <br>

## **Examples : Class  documentation**

```cs
namespace DemoLibrary {

    public class Employee : IFormattable {

        public int Id;
        public string Name;
        public Address Address;
        public Department Department;

        public Employee(int pId, string pName, 
        Address address, Department department) {...}

        public string FormatInformations() {...}

    }

}
```

<h2 id='EmployeeAnchor'>DemoLibrary.Employee : <a href='#IFormattableAnchor'>IFormattable</a></h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> Id<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> Name<br>
<strong>public</strong> <strong></strong> <strong></strong> <strong>Address</strong> Address<br>
<strong>public</strong> <strong></strong> <strong></strong> <strong>Department</strong> Department<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> Employee(<strong>Int32</strong> pId, <strong>String</strong> pName, <strong>Address</strong> pAddress, <strong>Department</strong> pDepartment)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> FormatInformations()<br>

<br> <hr> <br>

## **Examples : Struct documentation**

```cs
namespace DemoLibrary {

    public struct Address {

        public int DoorNumber;
        public string StreetName;
        public string City;
        public string PostalCode;

    }

}
```

<h2 id='AddressAnchor'>DemoLibrary.Address <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> DoorNumber<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> StreetName<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> City<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> PostalCode<br> 

<br> <hr> <br>

## **Examples : Enum documentation**

```cs
namespace DemoLibrary {

    public enum Department {

        Sales,
        Marketing,
        HumanResources

    }

}
```

<h2 id='DepartmentAnchor'>DemoLibrary.Department</h2> <h4>Values : </h4>0 : <strong>Sales</strong>, <br> 
1 : <strong>Marketing</strong>, <br> 
2 : <strong>HumanResources</strong><br> 

<br> <hr> <br>

