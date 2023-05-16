using DI_Demo.IServices;

namespace DI_Demo.Services
{
    public class CombatServiceV2 : ICombatService
    {
        public int Damage(int atkPoint, int amor)
        {
            return atkPoint - amor;
        }
    }
}
