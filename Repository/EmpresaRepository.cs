using WebApiAspNetCoreDapper.Contracts;
using WebApiAspNetCoreDapper.Dto;
using WebApiAspNetCoreDapper.Entities;

namespace WebApiAspNetCoreDapper.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        
        public Task<Empresa> CreateEmpresa(EmpresaForCreationDto empresa)
        {
            throw new NotImplementedException();
        }

        public Task CreateMultipleEmpresas(List<EmpresaForCreationDto> empresas)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> GetEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> GetEmpresaByFuncionarioId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> GetEmpresaFuncionariosMultipleResults(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empresa>> GetEmpresas()
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> GetEmpresasFuncionariosMultipleMapping()
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmpresa(int id, EmpresaForUpdateDto empresa)
        {
            throw new NotImplementedException();
        }
    }
}
