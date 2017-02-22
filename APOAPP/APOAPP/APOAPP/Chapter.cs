using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAPP
{
    class Chapter
    {
        Common.HOST_ENTITY m_Entity;
        string m_Email;
        string m_PhoneNumber;
        Common.Address m_Address;
        Common.SECTION m_Section;

        public Chapter(Common.HOST_ENTITY entity, string email, string phoneNumber, Common.Address address, Common.SECTION section)
        {
            m_Entity = entity;
            m_Email = email;
            m_PhoneNumber = phoneNumber;
            m_Address = address;
            m_Section = section;            
        }
    }
}
