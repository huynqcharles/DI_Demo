using DI_Demo.IServices;

namespace DI_Demo.Services
{
    public class CombatService : ICombatService
    {
        public int Damage(int atkPoint, int amor)
        {
            return atkPoint;
        }
    }
}
