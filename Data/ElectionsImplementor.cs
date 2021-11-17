using System.Collections.Generic;

namespace Elections.Data
{
    public class ElectionsImplementor : IElectionsEndPoints
    {
        public void Create(IecParties cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteElections(IecParties cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IecParties> GetAllParties()
        {
           var parties = new List<IecParties>
            {
              new IecParties{PartyName="Afrian National Congress", PartyAbbr="ANC",Leader="Ramaphosa",RegistrationDate="01/11/1981"},
               new IecParties{PartyName="Democratic Alliance", PartyAbbr="DA",Leader="Zille",RegistrationDate="01/11/1981"},
               new IecParties{PartyName="Economic Freedom Fighters", PartyAbbr="EFF",Leader="Malema",RegistrationDate="01/11/1981"},
               new IecParties{PartyName="Inkata Freedom Party", PartyAbbr="IFP",Leader="Buthelezi",RegistrationDate="01/11/1981"},
            };
            return parties;
        }
    

        public IecParties GetPartyByAbbr(string PartyAbbr)
        {
           return new IecParties{PartyName="Democratic Alliance", PartyAbbr="DA",Leader="Zille",RegistrationDate="01/11/1981"};
        }
        
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(IecParties cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}