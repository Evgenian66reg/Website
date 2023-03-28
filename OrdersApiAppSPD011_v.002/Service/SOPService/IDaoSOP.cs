using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.SOPService
{
    public interface IDaoSOP
    {
        Task<List<StitchingOrderProduct>> GetAllAsync();
        Task<StitchingOrderProduct> AddAsync(StitchingOrderProduct sop);
        Task<StitchingOrderProduct> UpdateAsync(StitchingOrderProduct sop);
        Task<StitchingOrderProduct> DeleteAsync(int id);
        Task<StitchingOrderProduct> GetAsync(int id);
    }
}
