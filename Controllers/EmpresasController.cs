using WebApiAspNetCoreDapper.Contracts;
using WebApiAspNetCoreDapper.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAspNetCoreDapper.Entities;
using System.Reflection.Metadata.Ecma335;

namespace WebApiAspNetCoreDapper.Controllers
{
    [Route("api/empresas")]
    [ApiController]
    public class EmpresasController : Controller
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresasController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmpresas()
        {
            try
            {
                var empresas = await _empresaRepository.GetEmpresas();
                return Ok(empresas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
                throw;
            }
        }

        [HttpGet("{id}", Name = "EmpresaById")]
        public async Task<IActionResult> GetEmpresa(int id)
        {
            try
            {
                var empresa = await _empresaRepository.GetEmpresa(id);
                if (empresa == null)
                    return NotFound();

                return Ok(empresa);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmpresa(EmpresaForCreationDto empresa)
        {
            try
            {
                var createdEmpresa = await _empresaRepository.CreateEmpresa(empresa);
                return CreatedAtRoute("EmpresaById", new { id = createdEmpresa.Id }, createdEmpresa);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmpresa(int id, EmpresaForUpdateDto empresa)
        {
            try
            {
                var dbEmpresa = await _empresaRepository.GetEmpresa(id);
                if (dbEmpresa == null)
                    return NotFound();

                await _empresaRepository.UpdateEmpresa(id, empresa);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresa(int id)
        {
            try
            {
                var dbEmpresa = await _empresaRepository.GetEmpresa(id);
                if (dbEmpresa == null)
                    return NotFound();

                await _empresaRepository.DeleteEmpresa(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ByFuncionarioId/{id}")]
        public async Task<IActionResult> GetEmpresaForFuncionario(int id)
        {
            try
            {
                var empresa= await _empresaRepository.GetEmpresaByFuncionarioId(id);
                if (empresa == null)
                    return NotFound();

                return Ok(empresa);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}/MultipleResult")]
        public async Task<IActionResult> GetEmpresaFuncionariosMultipleResult(int id)
        {
            try
            {
                var empresa = await _empresaRepository.GetEmpresaFuncionariosMultipleResults(id);
                if (empresa == null)
                    return NotFound();

                return Ok(empresa);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("MultipleMapping")]
        public async Task<IActionResult> GetEmpresasFuncionariosMultipleMapping()
        {
            try
            {
                var empresas = await _empresaRepository.GetEmpresasFuncionariosMultipleMapping();

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("multiple")]
        public async Task<IActionResult> CreateEmpresa(List<EmpresaForCreationDto> empresas)
        {
            try
            {
                await _empresaRepository.CreateMultipleEmpresas(empresas);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

    }   
}
