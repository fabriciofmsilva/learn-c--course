namespace SimpleWebScraper
{
    class Person
    {
        private string _ssn;
        private string _passportData;
        private string _driversLicenceNumber;

        public Person(string ssn, string passportData, string diversLicenseNumber)
        {
            _ssn = ssn;
            _passportData = passportData;
            _driversLicenceNumber = diversLicenseNumber;
        }

        public bool HasProperDocuments {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenceNumber.Length > 0;
            }
        }
    }
}
