namespace IAM.Infrastructure.Repositories
{
	using IAM.Domain.SeedWork;
	using Microsoft.EntityFrameworkCore;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public class GenericEntityFrameworkCommandRepository<TContext> : ICommandRepository
		where TContext : DbContext
	{
		public GenericEntityFrameworkCommandRepository(TContext context)
		{
		}

		public IUnitOfWork UnitOfWork => throw new System.NotImplementedException();

		int ICommandRepository.Delete<T>(T aggregateRoot)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.Delete<T>(object pk)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.DeleteAll<T>(IEnumerable<T> aggregateRoots)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.DeleteAll<T>()
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.DeleteAllAsync<T>(IEnumerable<T> aggregateRoots)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.DeleteAllAsync<T>()
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.DeleteAsync<T>(T aggregateRoot)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.DeleteAsync<T>(object pk)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.Insert<T>(T aggregateRoot, string createdBy)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.InsertAll<T>(IEnumerable<T> aggregateRoots, string createdBy)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.InsertAllAsync<T>(IEnumerable<T> aggregateRoots, string createdBy)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.InsertAsync<T>(T aggregateRoot, string createdBy)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.Update<T>(T aggregateRoot, string modifiedBy)
		{
			throw new System.NotImplementedException();
		}

		int ICommandRepository.UpdateAll<T>(IEnumerable<T> aggregateRoots, string modifiedBy)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.UpdateAllAsync<T>(IEnumerable<T> aggregateRoots, string modifiedBy)
		{
			throw new System.NotImplementedException();
		}

		Task<int> ICommandRepository.UpdateAsync<T>(T aggregateRoot, string modifiedBy)
		{
			throw new System.NotImplementedException();
		}
	}
}
