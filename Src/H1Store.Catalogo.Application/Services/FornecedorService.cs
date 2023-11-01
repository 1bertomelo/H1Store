using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
	public class FornecedorService : IFornecedorService
	{
		private readonly IFornecedorRepository _fornecedorRepository;
		private readonly IMapper _Mapper;

		public async Task Adicionar(NovoFornecedorViewModel novoFornecedorViewModel)
		{
			//regra de negocio verificar aqui se existe cpnj ja cadastrado
			//senao existir chama o repositoo
			//se existir da erro que ja exist fornecedor cadastrado
			
			Fornecedor fornecedor = _Mapper.Map<Fornecedor>(novoFornecedorViewModel);
			await _fornecedorRepository.Adicionar(fornecedor);
		}

		public Task<FornecedorViewModel> ObterPorCnpj(string cnpj)
		{
			throw new NotImplementedException();
		}

		public Task<FornecedorViewModel> ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public async  Task<IEnumerable<FornecedorViewModel>> ObterTodos()
		{
			var listaFornecedores = await _fornecedorRepository.ObterTodos();
			return _Mapper.Map<IEnumerable<FornecedorViewModel>>(listaFornecedores);
		  //return _Mapper.Map<IEnumerable<FornecedorViewModel>>
		  //(await _fornecedorRepository.ObterTodos());

		}

		public Task Remover(FornecedorViewModel fornecedor)
		{
			throw new NotImplementedException();
		}
	}
}
