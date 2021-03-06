using System.Collections.Generic;
using System.Linq;
using patient.Models;
using Microsoft.AspNetCore.Mvc;



namespace Patient.Controllers
{
[Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private PatientContext Context;
        public PatientController(PatientContext context)
        {
            this.Context = context;
        }
        /*[HttpGet]
        public ActionResult<IEnumerable<Patient>> Get()
        {
            return Context.patients.ToList();
        }*/
        
       [HttpGet("{id}")]
        public ActionResult<Patient> GetId(int id)
        {
           return Context.patients.FirstOrDefault(x=>x.patient_id==id);
           
        }
       
        [HttpGet("{name}")]
        public ActionResult<Patient> GetName(string name)
        {
           return Context.patients.FirstOrDefault(x=>x.patient_name==name);
           
        }

        [HttpGet("{date}")]
        public ActionResult<IEnumerable<Patient>>GetDate(string date)
        {
            
           //return Context.patients.FirstOrDefault(x=>x.appointment_date==date);
           List<Patient>lists=Context.patients.Where(p=>p.appointment_date==date).ToList();
           return lists;
           //return Json(pr,JsonRequestBehaviour.AllowGet);
           
        }

        [HttpPost]
        public ActionResult<Patient> Post([FromBody]Patient product)
        {
            if(product==null)
            return BadRequest();
             Context.patients.Add(product);
             Context.SaveChanges();
             return Ok(product);
        }

       [HttpPut("{id}")]
        public ActionResult<Patient> Update(int? id,Patient product)
        {
            if(id==null)
            return BadRequest();
           Patient pr=Context.patients.FirstOrDefault(x=>x.patient_id==id);
        
        pr.patient_name = product.patient_name;
            pr.DOB =product.DOB;
            pr.address = product.address;
            pr.contact=product.contact;
            pr.email=product.email;
            pr.diagnosis_reason=product.diagnosis_reason;
            pr.doctor_name=product.doctor_name;
            pr.appointment_date=product.appointment_date;
            pr.appointment_time=product.appointment_time;

           Context.patients.Update(pr);
            Context.SaveChanges();
             return new NoContentResult();
        }

      

    }
}
