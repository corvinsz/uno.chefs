namespace Chefs.Business.Services.Users;

/// <summary>
/// Implements user related methods
/// </summary>
public interface IUserService
{
	/// <summary>
	/// Current user data
	/// </summary>
	/// <param name="ct"></param>
	/// <returns>
	/// User logged in
	/// </returns>
	ValueTask<User> GetCurrent(CancellationToken ct);

	/// <summary>
	/// Feed of the current user.
	/// </summary>
	IFeed<User> User { get; }

	/// <summary>
	/// Update user information
	/// </summary>
	/// <param name="user">user with information to update</param>
	/// <param name="ct"></param>
	/// <returns>
	/// </returns>
	ValueTask Update(User user, CancellationToken ct);

	/// <summary>
	/// Porpular creators related with the recipes
	/// </summary>
	/// <param name="ct"></param>
	/// <returns>
	/// Return users that they are popular by their recipes
	/// </returns>
	ValueTask<IImmutableList<User>> GetPopularCreators(CancellationToken ct);

	/// <summary>
	/// Returns specific user
	/// </summary>
	/// <param name="userId">User GUID</param>
	/// <returns>
	/// User
	/// </returns>
	ValueTask<User> GetById(Guid userId, CancellationToken ct);

	// <summary>
	// Authentication method
	// </summary>
	// <param name="email"> The user email </param>
	// <param name="ct"></param>
	// <returns>
	// User logged in
	// </returns>
	// In case we need auth
	//ValueTask<bool> BasicAuthenticate(string email, string password, CancellationToken ct);
}
