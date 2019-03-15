﻿using StudyProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StudyProject.Domain.Interfaces.Base;
using StudyProject.Domain.Interfaces.Application;

namespace StudyProject.Application
{
    public class ClientApplicationService: IClientApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Client>> GetAllClient()
        {
            return await _unitOfWork.Repository<Client>().GetAll().AsQueryable().ToListAsync();
           
        }

        public ICollection<Client> GetAll()
        {
            return _unitOfWork.Repository<Client>().GetAll();

        }
    }
}
