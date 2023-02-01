using System.Threading.Tasks;
using BoxBack.Domain.Interfaces;
using BoxBack.Domain.Models;
using Sigesp.Domain.InterfacesRepositories;
using System.Collections.Generic;
using BoxBack.Domain.ServicesThirdParty;
using BoxBack.Domain.InterfacesRepositories;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace BoxBack.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ILogger _logger;
        private readonly IClienteRepository _clienteRepository;
        private readonly IBCServices _bcServices;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public ClienteService(ILogger<ClienteService> logger,
                              IClienteRepository clienteRepository,
                              IBCServices bcServices,
                              IMapper mapper,
                              IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _clienteRepository = clienteRepository;
            _bcServices = bcServices;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    
        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAllAsync();
        }
        
        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}