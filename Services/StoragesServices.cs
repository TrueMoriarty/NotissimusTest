using DAL.EfClasses;
using DAL.Repositories;

namespace Services;

public interface IStoragesServices
{
    public List<Storage> GetStorages(string text);
}

public class StoragesServices(IStoragesRepository storagesRepository) : IStoragesServices
{
    public List<Storage> GetStorages(string text)
    {
        return storagesRepository.GetTextStorages(text);
    }
}