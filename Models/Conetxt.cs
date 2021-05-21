using Microsoft.EntityFrameworkCore;
using Marko.Models;

namespace Marko.Models
{
	public class Context : DbContext
	{

		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
		public DbSet<Joke> Jokes { get; set; }
	}

}
