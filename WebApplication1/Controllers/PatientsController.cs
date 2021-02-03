using ClassLibrary1.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : Controller
    {
        private readonly PatientsDbContext context = new PatientsDbContext();

        [HttpGet]
        public ActionResult<Patient> GetPatients()
        {
            return Ok(context.Patients);
        }
        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();

            return Ok();
        }
        [HttpDelete] 
        public ActionResult DeletePatient(int id)
        {
            var itemToDelete = context.Patients.ToList().FirstOrDefault(p => p.Id == id);
            if (itemToDelete == null) return NotFound($"Patient with id {id} not found");
            
            context.Patients.Remove(itemToDelete);
            context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdatePatient(Patient patient)
        {
            var itemToUpdate = context.Patients.ToList().FirstOrDefault(p => p.Id == patient.Id);
            if (itemToUpdate == null) return NotFound($"Patient with id {patient.Id} not found");

            itemToUpdate.Name = patient.Name;
            itemToUpdate.Surname = patient.Surname;
            itemToUpdate.dateOfBirth = patient.dateOfBirth;
            itemToUpdate.Diagnosis = patient.Diagnosis;
            context.SaveChanges();

            return Ok();
        }
    }
}
