using System;
using System.Text;

namespace hbehr.VCardGenerator
{
    public partial class VCard
    {
        public VCard SetImage(string image)
        {
            Image = image;
            return this;
        }

        public VCard SetName(string name)
        {
            Name = name;
            return this;
        }

        public VCard SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public VCard SetCompany(string company)
        {
            Company = company;
            return this;
        }

        public VCard SetTitle(string title)
        {
            Title = title;
            return this;
        }

        public VCard SetAddress(string address)
        {
            Address = address;
            return this;
        }

        public VCard SetCity(string city)
        {
            City = city;
            return this;
        }

        public VCard SetZipCode(string zip)
        {
            ZipCode = zip;
            return this;
        }

        public VCard SetCountry(string country)
        {
            Country = country;
            return this;
        }

        public VCard SetState(string state)
        {
            State = state;
            return this;
        }

        public VCard SetCellphone(string cellphone)
        {
            Cellphone = cellphone;
            return this;
        }

        public VCard SetTelephone(string telephone)
        {
            Telephone = telephone;
            return this;
        }

        public VCard SetFax(string fax)
        {
            Fax = fax;
            return this;
        }

        public VCard SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public VCard SetWebSite(string webSite)
        {
            WebSite = webSite;
            return this;
        }

        public VCard SetAboutMe(string aboutMe)
        {
            AboutMe = aboutMe;
            return this;
        }

        public string GetVCardContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCARD");
            sb.AppendLine("VERSION:3.0");
            if (!string.IsNullOrWhiteSpace(Name))
            {
                sb.AppendLine(string.Format("N:{0};{1};;;", LastName, Name));
                sb.AppendLine(string.Format("FN:{0} {1}", Name, LastName));
            }
            if (!string.IsNullOrWhiteSpace(Company))
            {
                sb.AppendLine("ORG:" + Company);
            }
            if (!string.IsNullOrWhiteSpace(Title))
            {
                sb.AppendLine("TITLE:" + Title);
            }
            if (!string.IsNullOrWhiteSpace(Email))
            {
                sb.AppendLine("EMAIL;TYPE=PREF,INTERNET:" + Email);
            }
            if (!string.IsNullOrWhiteSpace(Cellphone))
            {
                sb.AppendLine("TEL;TYPE=CELL,voice:" + Cellphone);
            }
            if (!string.IsNullOrWhiteSpace(Fax))
            {
                sb.AppendLine("TEL;TYPE=WORK,fax:" + Fax);
            }
            if (!string.IsNullOrWhiteSpace(Address))
            {
                sb.AppendLine(string.Format("ADR;TYPE=WORK;type=pref:;;{0};{1};;{2};{3}",
                    Address, City, ZipCode, Country));
            }
            if (!string.IsNullOrWhiteSpace(WebSite))
            {
                sb.AppendLine("URL:" + WebSite);
            }
            if (!string.IsNullOrWhiteSpace(Telephone))
            {
                sb.AppendLine("TEL;TYPE=WORK,voice:" + Telephone);
            }
            if (!string.IsNullOrWhiteSpace(Image))
            {
                sb.AppendLine("PHOTO;TYPE=JPG;ENCODING=B:" + Image);
            }
            if (!string.IsNullOrWhiteSpace(AboutMe))
            {
                sb.AppendLine("NOTE:" + AboutMe);
            }
            sb.AppendLine(string.Format("REV:{0:YYYY-MM-DDTHH:mm:ss}", DateTime.Now));
            sb.AppendLine("END:VCARD");
            return sb.ToString();
        }
    }
}