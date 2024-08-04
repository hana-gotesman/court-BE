using Court_BE.Services.LegalCases.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Court_BE.Services.LegalCases.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LegalCaseController : ControllerBase
    {
        private readonly LegalCases _service;

        public LegalCaseController(LegalCases service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all cases
        /// </summary>
        /// <returns></returns>
       // [Authorize(Policy = Permissions.Program_Read)]
        [HttpGet]
        public List<Case> GetAllCases()
        {
            List<Case> cases =  _service.GetAllCases();
            return (List<Case>)cases;
        }

    }
}
