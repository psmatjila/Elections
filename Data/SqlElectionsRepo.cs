using System.Collections.Generic;
using System.Linq;


namespace Elections.Data
{
    class SqlElectionsRepo : IElectionsEndPoints
    {
        private readonly ElectionsContext _eContext;
        public SqlElectionsRepo(ElectionsContext eContext)
        {
            _eContext = eContext;
        }

        public void Create(IecParties cmd)
        {
            if (cmd == null)
            {
                throw new System.ArgumentNullException(nameof(cmd));
            }
            _eContext.NovElections.Add(cmd);
        }

        public void DeleteElections(IecParties cmd)
        {
            if(cmd == null)
            {
               throw new System.NotImplementedException();
            }

            _eContext.Remove(cmd);           
        }

        public IEnumerable<IecParties> GetAllParties()
        {
           return _eContext.NovElections.ToList();
        }

        public IecParties GetPartyByAbbr(string PartyAbbr)
        {
            return _eContext.NovElections.FirstOrDefault(p => p.PartyAbbr == PartyAbbr);
        }
        public bool SaveChanges()
        {
            int v = _eContext.SaveChanges();
            return true;
        }

        public void Update(IecParties cmd)
        {
            //Nothing
        }
    }
}