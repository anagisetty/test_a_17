using System;
using Test_A_17.DataAccess;
using Test_A_17.DTO;

namespace Test_A_17.Service
{
    public class ProposalService
    {
        private ProposalRepository _repository;

        public ProposalService()
        {
            _repository = new ProposalRepository();
        }

        public void Create(Proposal proposal)
        {
            if (proposal.CreationDate > proposal.LimitDate)
            {
                throw new Exception("Backdated Proposal is not allowed");
            }

            _repository.Create(proposal);
        }

        public Proposal Get(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Proposal proposal)
        {
            if (proposal.CreationDate > proposal.LimitDate)
            {
                throw new Exception("Backdated Proposal is not allowed");
            }
            _repository.Update(proposal);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}