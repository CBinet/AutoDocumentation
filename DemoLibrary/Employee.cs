namespace DemoLibrary {

    public class Employee : IFormattable {

        public int Id;
        public string Name;
        public Address Address;
        public Department Department;

        public Employee(int pId, string pName, Address address, Department department) {
            Id = pId;
            Name = pName;
            Address = address;
            Department = department;
        }

        public string GetFormattedInformations() {
            return string.Format(
                                 "ID : {0}, Name : {1}, Address : {2}, Department : {3}",
                                 Id,
                                 Name,
                                 Address.GetFormattedInformations(),
                                 Department);
        }

        public void Format() {
            throw new System.NotImplementedException();
        }

    }

}