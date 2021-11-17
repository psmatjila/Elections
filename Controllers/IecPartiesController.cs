
using System.Collections.Generic;
using Elections.Data;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Elections.Dtos;

namespace Elections.Controllers
{
    //For out of the box behaviours
    [Route("api/[controller]")]
    [ApiController]
    public class IecPartiesController : ControllerBase
    {
       //private readonly ElectionsImplementor _implementor =  new ElectionsImplementor();

      private readonly IElectionsEndPoints _implementor;
      private readonly IMapper _mapper;
       public IecPartiesController(IElectionsEndPoints implementor,IMapper mapper)
       {
           _implementor = implementor;
           _mapper = mapper;
       }
       
       
        //GET api/commands/{id}
        [HttpGet("{abbri}")]
        //these id comes from the request.
        public ActionResult <ElectionsReadDto> GetPartyByAbbr(string abbri)
        {
           var partyItem = _implementor.GetPartyByAbbr(abbri);
        
           if (partyItem != null)
           {
              return Ok(_mapper.Map<ElectionsReadDto>(partyItem));
           }
              return NotFound();
        
        }

        [HttpGet]
        //IEnumerable<Command> IEnumerable of Command
        public ActionResult <IEnumerable<IecParties>> GetAllParties()
        { 
            //Get all the commands by using the method GetAppCommands
            var partiesItems = _implementor.GetAllParties();

            return Ok(partiesItems);

        }

        //POST api/commands
        [HttpPost]
        public ActionResult <ElectionsCreateDto> Create(ElectionsCreateDto electionsCreateDto)
        {
            var elctionsModel = _mapper.Map<IecParties>(electionsCreateDto);
            _implementor.Create(elctionsModel);
            _implementor.SaveChanges();

            return Ok(elctionsModel);
        }

        //PUT api/commands
        [HttpPut("{abbr}")]
        public ActionResult Update(string abbr, ElectionsUpdateDto  electionsUpdateDto)
        {
            var electionsModelFromRepo = _implementor.GetPartyByAbbr(abbr);

            if (electionsModelFromRepo == null) //not entry was found in the table
            {
                return NotFound();
            }
            //Art
            // UpdateElections was made to return nothing  simply because by 
            //mapping it to electionsModelFromRepo, then electionsUpdateDto get updated automatically.
            _mapper.Map(electionsUpdateDto,electionsModelFromRepo);
            //We are just calling UpdateElections, for good coding practice.
            _implementor.Update(electionsModelFromRepo);

            _implementor.SaveChanges();

            return NoContent();
        }

         //Delete api/commands
        [HttpDelete("{abbr}")]
        public ActionResult DeleteElections(string abbr)
        {
            var electionsModelFromRepo = _implementor.GetPartyByAbbr(abbr);

            if (electionsModelFromRepo == null)
            {
               return NotFound();
            }
            _implementor.DeleteElections(electionsModelFromRepo);
            _implementor.SaveChanges();
            return NoContent();
        }

    }
}