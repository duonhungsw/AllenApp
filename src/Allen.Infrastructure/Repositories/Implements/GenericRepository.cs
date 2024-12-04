namespace Allen.Infrastructure.Repositories.Implements;

public class GenericRepository<T> : IGenericRepository<T> where T : Entity<Guid>
{
	protected readonly ApplicationDbContext _context;
	public GenericRepository(ApplicationDbContext context)
	{
		_context = context;
	}
	public void Create(T entity)
	{
		_context.Set<T>().Add(entity);
	}

	public void Delete(T entity)
	{
		_context.Set<T>().Remove(entity);
	}

	public bool Exist(Guid id)
	{
		return _context.Set<T>().Any(x => x.Id == id);
	}

	public async Task<IEnumerable<T>> GetAllAsync()
	{
		return await _context.Set<T>().ToListAsync();
	}

	public async Task<T?> GetByIdAsync(Guid id)
	{
		return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
	}

	public async Task<bool> SaveChangesAsync()
	{
		return await _context.SaveChangesAsync() > 0;
	}

	public void Update(T entity)
	{
		_context.Set<T>().Attach(entity);
		_context.Entry(entity).State = EntityState.Modified;
	}
}
