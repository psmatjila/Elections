using System.Collections.Generic;

namespace Elections.Data
{
    public interface IElectionsEndPoints
    {
        //Contruct items
        IEnumerable<IecParties> GetAllParties();
        IecParties GetPartyByAbbr(string PartyAbbr);

        bool SaveChanges();
        void Create(IecParties cmd);

        void Update(IecParties cmd);

        void DeleteElections(IecParties cmd);

    }
}