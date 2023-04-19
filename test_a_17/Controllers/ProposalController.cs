using test_a_17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_a_17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateProposal(Proposal proposal)
        {
            if (proposal.DateCreated < DateTime.Now.AddMonths(-1))
            {
                return BadRequest(new { error = "Backdated proposals can not be created beyond a certain limit to maintain accuracy"});
            }

            // Create Proposal
            var newProposal = new Proposal();

            // Save Proposal

            return Ok(newProposal);
        }
    }
}