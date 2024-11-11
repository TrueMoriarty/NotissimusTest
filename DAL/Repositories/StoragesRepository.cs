using DAL.EfClasses;
using DAL.EfCode;

namespace DAL.Repositories;

public interface IStoragesRepository
{
    List<Storage> GetTextStorages(string text);
}

public class StoragesRepository(NotissimusContext context) : IStoragesRepository
{
    public List<Storage> GetTextStorages(string text)
    {
        var query = context.Storages.Where(t => t.Text.Contains(text));
        return query.ToList();
    }
}