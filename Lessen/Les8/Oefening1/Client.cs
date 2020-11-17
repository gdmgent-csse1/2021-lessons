using System.Collections.Generic;

namespace Clients
{
    public class Client
    {
        /// <summary>
        /// Class for the creation of a client.
        /// </summary>
        
        // Fields
        private string name;
        //private ContactPerson cp;
        private List<ContactPerson> contactpersons;
        private string vat;
        //private Address companyAddress;
        private List<Address> companyAddresses;
        private string remarks;
        private ClientType type;

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        /*
        public ContactPerson ContactPerson
        {
            get
            {
                return this.cp;
            }
            set
            {
                this.cp = value;
            }
        }
        */
        public List<ContactPerson> ContactPersons
        {
            get
            {
                return this.contactpersons;
            }
            set
            {
                this.contactpersons = value;
            }
        }
        public string Vat
        {
            get
            {
                return this.vat;
            }
            set
            {
                this.vat = value;
            }
        }
        /*
        public Address CompanyAddress
        {
            get
            {
                return this.companyAddress;
            }
            set
            {
                this.companyAddress = value;
            }
        }
        */
        public List<Address> CompanyAddresses
        {
            get
            {
                return this.companyAddresses;
            }
            set
            {
                this.companyAddresses = value;
            }
        }
        public string Remarks
        {
            get
            {
                return this.remarks;
            }
            set
            {
                this.remarks = value;
            }
        }

        public ClientType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        // Constructors
        public Client()
        {}
        //public Client(string name, ContactPerson contactPerson, string vatnumber, Address address, string remarks, ClientType t)
        public Client(string name, List<ContactPerson> contactPersons, string vatnumber, List<Address> addresses, string remarks, ClientType t)
        {
            this.Name = name;
            //this.ContactPerson = contactPerson;
            this.ContactPersons = contactPersons;
            this.Vat = vatnumber;
            //this.CompanyAddress = address;
            this.CompanyAddresses = addresses;
            this.Remarks = remarks;
            this.Type = type;
        }

        // Methods
    }
}