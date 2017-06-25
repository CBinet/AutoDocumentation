# AutoDocumentation

### Installation
To install BetaSoftwares.AutoDocumentation, run the following command in the <a href='#https://docs.microsoft.com/fr-fr/nuget/tools/package-manager-console'>Package Manager Console</a>  :

```
PM> Install-Package BetaSoftware.AutoDocumentation
```

### Usage
To start using **AutoDocumentation**, simply call the GenerateDocumentation method of the **AutoDocumentation** class with the project assembly :

```cs
var assembly = Assembly.LoadFrom(pathToDll); // Load the assembly
AutoDocumentation.GenerateDocumentation(assembly) // Generate doc !
```

### Examples

#### Class documentation
Example code :
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
Documentation generated : 
<hr><h2 id='EmployeeAnchor'>DemoLibrary.Employee</h2> <h3>Fields : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>Int32</strong> Id<br> 
<strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> Name<br> 
 <h3>Constructors : </h3><strong>public</strong> <strong></strong> Employee(<strong>Int32</strong> pId, <strong>String</strong> pName)<br> 
 <h3>Methods : </h3><strong>public</strong> <strong></strong> <strong></strong> <strong>String</strong> GetFormattedInformations()<br> 

#### Interface documentation
Example code :
```cs
namespace DemoLibrary {

    public interface IFormattable {

        string GetFormattedInformations();

        void Format();

    }

}
```
Documentation generated :
