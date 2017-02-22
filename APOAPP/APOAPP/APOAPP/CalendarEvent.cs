using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAPP
{
    class CalendarEvent
    {
        //necessary information
        string m_EventName;
        string m_ShortDesc;
        string m_LongDesc;
        DateTime m_DateTime;
        Common.HOST_ENTITY m_HostEntity;
        string m_HostEmail;
        string m_HostPhoneNumber;
        Common.Address m_EventAddress;

        //optional information
        string m_SocialMediaURL;
        string m_ImageSharingURL;

        //constructor
        public CalendarEvent(string eventName, string shortDesc, string LongDesc, DateTime dateTime, Common.HOST_ENTITY hostEntity, string hostEmail, string hostPhoneNumber, Common.Address eventAddress )
        {
            m_EventName = eventName;
            m_ShortDesc = shortDesc;
            m_LongDesc = LongDesc;
            m_DateTime = dateTime;
            m_HostEntity = hostEntity;
            m_HostEmail = hostEmail;
            m_HostPhoneNumber = hostPhoneNumber;
            m_EventAddress = eventAddress;
        }
    }
}
