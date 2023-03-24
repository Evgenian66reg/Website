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
            throw new NotImplementedException();
        }

        public Task<List<StitchingOrderProduct>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StitchingOrderProduct> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StitchingOrderProduct> UpdateAsync(StitchingOrderProduct sop)
        {
            throw new NotImplementedException();
        }
    }
}
