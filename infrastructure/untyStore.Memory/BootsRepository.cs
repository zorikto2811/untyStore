using System;
using System.Linq;

namespace untyStore.Memory
{
    public class BootsRepository : IBootsRepository
    {
        private readonly Boot[] boots = new[]
        {
            new Boot(1, "37 размер"),
            new Boot(2,"38 размер"),
            new Boot(3,"42 размер")
        };
        public Boot[] GetAllByTitle(string titlePart)
        {
            return boots.Where(boot => boot.Title.Contains(titlePart))
                            .ToArray();
        }
    }
}
