using ConsoleApp2.Contexts;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

ShopDbContext shopDbContext = new ShopDbContext();
GetById();

void GetAll()
{
    IQueryable<Category> query = shopDbContext.Categories.Where(x => !x.IsDeleted).AsNoTracking();

    IEnumerable<Category> categories = query.ToList();

    foreach (Category category in categories)
    {
        Console.WriteLine($"Id:{category.Id} Name:{category.Name} CreatedAt:{category.CreatedAt} UpdatedAt:{category.UpdatedAt}");
    }

}

void GetById()
{
    Console.WriteLine("Input Id:");
    int.TryParse(Console.ReadLine(), out int id);

    Category? category = shopDbContext.Categories.Where(x => !x.IsDeleted)
        .AsNoTracking()
        .FirstOrDefault(x => x.Id == id);

    if (category != null)
    {

        Console.WriteLine($"Id:{category.Id} Name:{category.Name} CreatedAt:{category.CreatedAt} UpdatedAt:{category.UpdatedAt}");
    }
}
