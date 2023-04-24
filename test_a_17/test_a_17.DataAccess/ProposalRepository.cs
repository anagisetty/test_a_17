using System;
using Test_A_17.DTO;

namespace Test_A_17
{
    public class ProposalRepository
    {
        public void Create(Proposal proposal)
        {
            if (proposal.CreationDate > proposal.LimitDate)
            {
                throw new Exception("Backdated Proposal is not allowed");
            }

            // Code to create proposal
        }

        public Proposal Get(int id)
        {
            // Code to get proposal
        }

        public void Update(Proposal proposal)
        {
            if (proposal.CreationDate > proposal.LimitDate)
            {
                throw new Exception("Backdated Proposal is not allowed");
            }
            // Code to update proposal
        }

        public void Delete(int id)
        {
            // Code to delete proposal
        }
    }
}