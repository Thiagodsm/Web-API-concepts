using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        Breakfast GetBreakfast(Guid id);
        public void UpsertBreakfast(Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}
