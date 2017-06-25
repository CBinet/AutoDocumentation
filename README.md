# AutoDocumentation

## Installation
To install BetaSoftwares.AutoDocumentation, run the following command in the <a href='#https://docs.microsoft.com/fr-fr/nuget/tools/package-manager-console'>Package Manager Console</a>  :

```
PM> Install-Package BetaSoftware.AutoDocumentation
```

<br> <hr> <br>

## Usage
To start using **AutoDocumentation**, simply call the GenerateDocumentation method of the **AutoDocumentation** class with the project assembly :

```cs
var assembly = Assembly.LoadFrom(pathToDll); // Load the assembly
AutoDocumentation.GenerateDocumentation(assembly) // Generate doc !
```

<br> <hr> <br>

## Class documentation

**Example code :**
```cs
namespace DemoLibrary {

    public class Employee {

        public int Id;
        public string Name;

        public Employee(int pId, string pName) {...}

        public string GetFormattedInformations() {...}

    }

}
```

<br>

**Generated documentation :** 
<h2 id='EmployeeAnchor'>DemoLibrary.Employee</h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> Id<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> Name<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> Employee(<strong>Int32</strong> pId, <strong>String</strong> pName)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> GetFormattedInformations()<br> <br>

<br> <hr> <br>

## Interface documentation

**Example code :**
```cs
namespace DemoLibrary {

    public interface IFormattable {

        string GetFormattedInformations();

        void Format();

    }

}
```

<br>

**Generated documentation :**
<h2 id='IFormattableAnchor'>DemoLibrary.IFormattable : </h2>   <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>String</strong> GetFormattedInformations()<br> 
<strong>public</strong> <strong></strong> <strong>abstract</strong> <strong>Void</strong> Format()<br> 

<br> <hr> <br>

## Struct documentation

**Example code :**
```cs
namespace DemoLibrary {

    public struct Address : IFormattable {

        public int DoorNumber;
        public string StreetName;
        public string City;
        public string PostalCode;

        public Address(int doorNumber, string streetName,
                    string city, string postalCode) 
                    {...}

        public string GetFormattedInformations() {...}

        public void Format() {...}

    }

}
```

<br>

**Generated documentation :**
<h2 id='AddressAnchor'>DemoLibrary.Address : <a href='#IFormattableAnchor'>IFormattable</a></h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> DoorNumber<br> 
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

<br> <hr> <br>

## Enum documentation :

**Example code :**
```cs
namespace DemoLibrary {

    public enum Department {

        Sales,
        Marketing,
        HumanResources

    }

}
```

<br>

**Generated documentation :**
<h2 id='DepartmentAnchor'>DemoLibrary.Department</h2> <h4>Values : </h4>0 : <strong>Sales</strong>, <br> 
1 : <strong>Marketing</strong>, <br> 
2 : <strong>HumanResources</strong><br> 

<br> <hr> <br>

