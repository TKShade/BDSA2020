﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Lecture09.Entities
{
    public interface ISuperheroContext
    {
        DbSet<Superhero> Superheroes { get; }
        DbSet<City> Cities { get; }
        DbSet<Power> Powers { get; }
        DbSet<SuperheroPower> SuperheroPowers { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
