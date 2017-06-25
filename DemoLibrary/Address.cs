namespace DemoLibrary {

    public struct Address : IFormattable {

        public int DoorNumber;
        public string StreetName;
        public string City;
        public string PostalCode;

        public Address(int doorNumber, string streetName, string city, string postalCode) {
            DoorNumber = doorNumber;
            StreetName = streetName;
            City = city;
            PostalCode = postalCode;
        }

        public string GetFormattedInformations() {
            return string.Format("{0} {1}, {2} ({3})", DoorNumber, StreetName, City, PostalCode);
        }

        public void Format() {
            throw new System.NotImplementedException();
        }

    }

}