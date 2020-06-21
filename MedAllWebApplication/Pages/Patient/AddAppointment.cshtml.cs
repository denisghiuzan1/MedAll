using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedAllWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedAll;

namespace MedAllWebApplication.Pages.Patient
{
    public class AddAppointmentModel : PageModel
    {
        private readonly MedAllControllerClient medAllControllerClient;

        public List<DoctorDTO> Doctors { get; set; }

        public AddAppointmentModel()
        {
            medAllControllerClient = new MedAllControllerClient();
            Doctors=new List<DoctorDTO>();
        }

        [BindProperty(SupportsGet = true)]
        public string FirstName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string LastName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ChosenDoctor { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ChosenDate { get; set; }
        public async Task OnGetAsync()
        {
            var doctors = await medAllControllerClient.GetAllDoctorsAsync();
            foreach (var doctor in doctors)
            {
               Doctors.Add(new DoctorDTO
                {
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName
                });
            }
        }
    }
}