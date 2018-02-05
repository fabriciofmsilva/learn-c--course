using System;

namespace SimpleWebScraper
{
    class Person
    {
        private string _ssn = "SSN";
        private string _passportData = "Data";
        private string _drivesLicenceNumber = "More Data";
        private string _firstName = "Avetis";
        private string _lastName = "Ghukasyan";

        public bool HasProperDocuments {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _drivesLicenceNumber.Length > 0;
            }
        }

        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted.");
                    return;
                }

                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted.");
                    return;
                }

                _lastName = value;
            }
        }
    }
}
