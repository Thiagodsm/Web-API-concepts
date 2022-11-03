using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        // here we should develop the methods to store the data in the database with some ORM like entity framework.
        // But for simplified, the data will be store in a Dict varible 
        public static readonly Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();

        public void CreateBreakfast(Breakfast breakfasts)
        {
            // simulate a insert in database
            _breakfasts.Add(breakfasts.Id, breakfasts);
        }

        public Breakfast GetBreakfast(Guid id)
        {
            return _breakfasts[id];
        }
    }
}


