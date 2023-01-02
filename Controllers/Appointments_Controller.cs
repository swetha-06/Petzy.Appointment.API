using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzy.Appointment.DataAccess.RepositoryImpl;
using Petzy.Appointment.Domain_.Repository;

namespace Petzy.Appointment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Appointments_Controller : ControllerBase
    {
        public IViewAppointmentRepository repository = new ViewAppointmentRepository();

        [HttpGet]
        public IActionResult GetAllAppointment() 
        {
            return Ok(repository.ViewAllAppointments());
        }
    }
}
