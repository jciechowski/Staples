using System;

namespace Repository
{

    public class Database : ILoadable, ISaveable
    {
        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Save(LogDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
