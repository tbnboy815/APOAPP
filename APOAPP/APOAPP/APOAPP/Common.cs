using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAPP
{
    public class Common
    {
        public struct Address
        {
            string m_StreetAddress;
            string m_Building;
            string m_City;
            string m_State;
            int m_ZipCode;

            Address(string streetAddress, string building, string city, string state, int zipCode)
            {
                m_StreetAddress = streetAddress;
                m_Building = building;
                m_City = city;
                m_State = state;
                m_ZipCode = zipCode;
            }
        };
        public enum HOST_ENTITY
        {
            REGION_1,
            SECTION_94,
            SECTION_96,
            SECTION_97,
            SECTION_101,
            SECTION_102,
            CHAPTER_PHI_EPSILON,
            CHAPTER_ALPHA_GAMMA_PI,
            CHAPTER_THETA_ZETA,
            CHAPTER_ALPHA_ZETA_SIGMA,
            CHAPTER_ALPHA_GAMMA_ETA,
            CHAPTER_ALPHA_CHI
            //TODO: ADD REST OF CHAPTERS
        };
        public enum SECTION
        {
            SECTION_94,
            SECTION_96,
            SECTION_97,
            SECTION_101,
            SECTION_102
        };
    }
}
