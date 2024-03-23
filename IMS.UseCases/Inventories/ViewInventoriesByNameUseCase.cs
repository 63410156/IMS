using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    // use outside inventoryRepository that is not instanceate in the class
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        // construction also require the instance of inventoryRepository abstraction
        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository) // plug in by InventoryRepository plugin
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            // return a list of Inventory by name parameter which default value is ""
            // pass through inventories
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        } 
    }
}
