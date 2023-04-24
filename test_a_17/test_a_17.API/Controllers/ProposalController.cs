using System;
using Microsoft.AspNetCore.Mvc;
using Test_A_17.DataAccess;
using Test_A_17.DTO;
using Test_A_17.Service;

namespace Test_A_17.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private ProposalService _proposalService;

        public ProposalController()
        {
            _proposalService = new ProposalService();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Proposal proposal)
        {
            try
            {
                if (proposal.CreationDate > proposal.LimitDate)
                {
                    throw new Exception("Backdated Proposal is not allowed");
                }

                _proposalService.Create(proposal);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                var proposal = _proposalService.Get(id);
                return Ok(proposal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Proposal proposal)
        {
            try
            {
                if (proposal.CreationDate > proposal.LimitDate)
                {
                    throw new Exception("Backdated Proposal is not allowed");
                }

                _proposalService.Update(proposal);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _proposalService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}