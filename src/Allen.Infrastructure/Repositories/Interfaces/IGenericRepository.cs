namespace Allen.Infrastructure.Repositories.Interfaces;

public interface IGenericRepository<T> where T : Entity<Guid>
{
	Task<T?> GetByIdAsync(Guid id);
	Task<IEnumerable<T>> GetAllAsync();
	//Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IQueryable<T>>? includeQuery = null);
	void Delete(T entity);
	void Update(T entity);
	void Create(T entity);
	bool Exist(Guid id);
	Task<bool> SaveChangesAsync();

	//bool CheckIfExists<T>(Func<T, bool> predicate) where T : class;
}
