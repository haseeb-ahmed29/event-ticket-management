using Microsoft.EntityFrameworkCore;
using EventTicketManagement.Models;

namespace EventTicketManagement.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events => Set<Event>();
}
