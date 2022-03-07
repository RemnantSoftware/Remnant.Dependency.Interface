using System;

namespace Remnant.Dependency.Interface
{
	public interface IContainer
	{
		/// <summary>
		/// Register a singleton using a specified type to resolve
		/// </summary>
		/// <typeparam name="TType">The type that will be used to resolve the singleton entry</typeparam>
		/// <param name="instance">The singleton instance</param>
		/// <returns>Returns the container</returns>
		IContainer Register<TType>(object instance) where TType : class;

		/// <summary>
		/// Register a singleton using a specified type to resolve
		/// </summary>
		/// <typeparam name="TType">The type that will be used to resolve the singleton entry</typeparam>
		/// <param name="instance">The singleton instance</param>
		/// <returns>Returns the container</returns>
		IContainer Register(Type type, object instance);

		/// <summary>
		/// Register a singleton
		/// </summary>
		/// <param name="instance">The singleton instance</param>
		/// <returns>Returns the container</returns>
		IContainer Register(object instance);

		/// <summary>
		/// Register a sing;eton with the container
		/// </summary>
		/// <typeparam name="TType">The type that will be used to resolve and construct entry</typeparam>
		/// <returns>Returns the container</returns>
		IContainer Register<TType>() where TType : class, new();

		/// <summary>
		/// Register a singleton with the container
		/// </summary>
		/// <typeparam name="TType">The type that will be used to resolve entry</typeparam>
		/// <typeparam name="TObject">The type that will be constructed and return on resolve</typeparam>
		/// <returns>Returns the container</returns>
		IContainer Register<TType, TObject>() where TType : class where TObject : class, new();


		/// <summary>
		/// Deregister a container entry using generic type
		/// </summary>
		/// <typeparam name="TType">The type that was registered</typeparam>
		IContainer DeRegister<TType>() where TType : class;

		/// <summary>
		/// Deregister a container entry using instance
		/// </summary>
		/// <param name="instance">The type of instance that will be removed from the container</param>
		IContainer DeRegister(object instance);

		/// <summary>
		/// Resolve type to get the instance
		/// </summary>
		/// <typeparam name="TType">The type that was registered</typeparam>
		/// <returns>Returns a singleton instance of the specified type</returns>
		TType ResolveInstance<TType>() where TType : class;

		/// <summary>
		/// Clear container from all registeries
		/// </summary>
		IContainer Clear();

		/// <summary>
		/// Returns the internal container that to be used for direct access
		/// </summary>
		/// <typeparam name="TContainer">Specify the type for the internal container. Exception will be thrown if casting fails.</typeparam>
		/// <returns></returns>
		TContainer InternalContainer<TContainer>() where TContainer: class;
	}
}
