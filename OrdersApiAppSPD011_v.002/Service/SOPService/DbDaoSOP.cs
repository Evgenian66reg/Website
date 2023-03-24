using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.SOPService
{
    public class DbDaoSOP : IDaoSOP
    {
        private static List<StitchingOrderProduct> plugSOPs = new List<StitchingOrderProduct>();
        private static int currentId = 1;

        public Task<StitchingOrderProduct> AddAsync(StitchingOrderProduct sop)
        {
            sop.Id = currentId++;
            plugSOPs.Add(sop);
            return Task.Run(() => sop);
        }

        public Task<StitchingOrderProduct> DeleteAsync(int id)
        {
            StitchingOrderProduct sop = plugSOPs[id];
            plugSOPs.Remove(sop);
            return Task.Run(() => sop);     
        }

        public Task<List<StitchingOrderProduct>> GetAllAsync()
        {
            return Task.Run(() => plugSOPs);
        }

        public Task<StitchingOrderProduct> GetAsync(int id)
        {
            StitchingOrderProduct sop = plugSOPs[id];
            plugSOPs.IndexOf(sop);
            return Task.Run(() => sop);
        }

        public Task<StitchingOrderProduct> UpdateAsync(StitchingOrderProduct sop)
        {
            plugSOPs.Insert(sop.Id, sop);
            return Task.Run(() => sop);
        }
    }
}
