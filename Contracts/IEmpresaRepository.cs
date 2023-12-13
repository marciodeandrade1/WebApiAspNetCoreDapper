using WebApiAspNetCoreDapper.Dto;
using WebApiAspNetCoreDapper.Entities;

namespace WebApiAspNetCoreDapper.Contracts
{
    public interface IEmpresaRepository
    {
        public Task<IEnumerable<Empresa>> GetEmpresas();
        public Task<Empresa> GetEmpresa(int id);
        public Task<Empresa> CreateEmpresa(EmpresaForCreationDto empresa);
        public Task UpdateEmpresa(int id, EmpresaForUpdateDto empresa);
        public Task DeleteEmpresa(int id);
        public Task<Empresa> GetEmpresaByFuncionarioId(int id);
        public Task<Empresa> GetEmpresaFuncionariosMultipleResults(int id);
        public Task<List<Empresa>> GetEmpresasFuncionariosMultipleMapping();
        public Task CreateMultipleEmpresas(List<EmpresaForCreationDto> empresas);
    }
}
