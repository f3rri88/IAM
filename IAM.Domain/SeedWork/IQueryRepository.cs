using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IAM.Domain.SeedWork
{
	public interface IQueryRepository
	{
		T GetById<T>(object pk) where T : class, IAggregateRoot;
		Task<T> GetByIdAsync<T>(object pk) where T : class, IAggregateRoot;
		IEnumerable<T> GetAll<T>() where T : class, IAggregateRoot;
		Task<IEnumerable<T>> GetAllAsync<T>() where T : class, IAggregateRoot;

		int GetCount<T>() where T : class, IAggregateRoot;
		Task<int> GetCountAsync<T>() where T : class, IAggregateRoot;
		bool GetExists<T>(object pk) where T : class, IAggregateRoot;
		Task<bool> GetExistsAsync<T>(object pk) where T : class, IAggregateRoot;

		IEnumerable<T> GetAll<T>(
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null,
			int? skip = null,
			int? take = null)
			where T : class, IAggregateRoot;

		Task<IEnumerable<T>> GetAllAsync<T>(
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null,
			int? skip = null,
			int? take = null)
			where T : class, IAggregateRoot;

		IEnumerable<T> Get<T>(
			Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null,
			int? skip = null,
			int? take = null)
			where T : class, IAggregateRoot;

		Task<IEnumerable<T>> GetAsync<T>(
			Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null,
			int? skip = null,
			int? take = null)
			where T : class, IAggregateRoot;

		T GetOne<T>(
			Expression<Func<T, bool>> filter = null,
			string includeProperties = null)
			where T : class, IAggregateRoot;

		Task<T> GetOneAsync<T>(
			Expression<Func<T, bool>> filter = null,
			string includeProperties = null)
			where T : class, IAggregateRoot;

		T GetFirst<T>(
			Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null)
			where T : class, IAggregateRoot;

		Task<T> GetFirstAsync<T>(
			Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = null)
			where T : class, IAggregateRoot;

		int GetCount<T>(Expression<Func<T, bool>> filter = null)
			where T : class, IAggregateRoot;

		Task<int> GetCountAsync<T>(Expression<Func<T, bool>> filter = null)
			where T : class, IAggregateRoot;

		bool GetExists<T>(Expression<Func<T, bool>> filter = null)
			where T : class, IAggregateRoot;

		Task<bool> GetExistsAsync<T>(Expression<Func<T, bool>> filter = null)
			where T : class, IAggregateRoot;
	}
}
