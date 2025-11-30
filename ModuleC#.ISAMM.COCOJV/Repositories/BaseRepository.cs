using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.Repositories
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly List<TEntity> _entityList; 

        public BaseRepository()
        {
            _entityList = new List<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _entityList;
        }

        public TEntity GetById(Guid id) 
        {
            return _entityList.FirstOrDefault(u => u.Id == id);
        }

        public Guid Post(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreatedDate = DateTime.UtcNow;
            _entityList.Add(entity);
            return entity.Id;
        }

        public void Put(TEntity entity) 
        {
            var existingEntity = GetById(entity.Id);
            if (existingEntity != null) 
            {
                existingEntity = entity; 
                existingEntity.UpdatedDate = DateTime.UtcNow;
            }
        }

        public void Delete(Guid id) 
        {
            var entity = GetById(id);
            if (entity != null) 
            {
                _entityList.Remove(entity);
            }
        }

    }
}
