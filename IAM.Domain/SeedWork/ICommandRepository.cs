using System.Collections.Generic;
using System.Threading.Tasks;

namespace IAM.Domain.SeedWork
{
	public interface ICommandRepository
	{
		IUnitOfWork UnitOfWork { get; }

		int Insert<T>(T aggregateRoot, string createdBy = null) where T : class, IAggregateRoot;
		Task<int> InsertAsync<T>(T aggregateRoot, string createdBy = null) where T : class, IAggregateRoot;
		int Update<T>(T aggregateRoot, string modifiedBy = null) where T : class, IAggregateRoot;
		Task<int> UpdateAsync<T>(T aggregateRoot, string modifiedBy = null) where T : class, IAggregateRoot;
		int Delete<T>(T aggregateRoot) where T : class, IAggregateRoot;
		Task<int> DeleteAsync<T>(T aggregateRoot) where T : class, IAggregateRoot;
		int Delete<T>(object pk) where T : class, IAggregateRoot;
		Task<int> DeleteAsync<T>(object pk) where T : class, IAggregateRoot;

		int InsertAll<T>(IEnumerable<T> aggregateRoots, string createdBy = null) where T : class, IAggregateRoot;
		Task<int> InsertAllAsync<T>(IEnumerable<T> aggregateRoots, string createdBy = null) where T : class, IAggregateRoot;
		int UpdateAll<T>(IEnumerable<T> aggregateRoots, string modifiedBy = null) where T : class, IAggregateRoot;
		Task<int> UpdateAllAsync<T>(IEnumerable<T> aggregateRoots, string modifiedBy = null) where T : class, IAggregateRoot;
		int DeleteAll<T>(IEnumerable<T> aggregateRoots) where T : class, IAggregateRoot;
		Task<int> DeleteAllAsync<T>(IEnumerable<T> aggregateRoots) where T : class, IAggregateRoot;

		int DeleteAll<T>() where T : class, IAggregateRoot;
		Task<int> DeleteAllAsync<T>() where T : class, IAggregateRoot;
	}
}
