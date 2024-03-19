using GLAB.Domains.Models.Laboratories;

namespace GLAB.Infra.Storages.LaboratoriesStorages;

public interface ILaboratoryStorage
{
    Task<List<Laboratory?>> SelectLaboratories();

    Task InsertLaboratory(Laboratory laboratory);

    Task UpdateLaboratory(Laboratory laboratory);

    Task UpdateLaboratoryStatus(string id);

    Task<bool> LaboratoryExistsByAcronyme(string acronyme);

    Task<bool> LaboratoryExistsById(string id);

    Task<LaboratoryStatus> GetLaboratoryStatus(string id);

    Task<Laboratory?> SelectLaboratoryById(string id);

    Task<Laboratory?> SelectLaboratoryByName(string name);


}