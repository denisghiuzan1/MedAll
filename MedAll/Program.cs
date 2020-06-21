using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAll
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AddData();
            //AddUser();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static void AddUser()
        {
            using (var context = new MedAllEntities2())
            {
                var user = new User
                {
                    Email = "admin",
                    Password = "admin",
                };

                var role = new Role
                {
                    Name = "admin"
                };
                user.Role = role;
                role.Users.Add(user);
                context.Roles.Add(role);
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        private static void AddData()
        {
            using (var context = new MedAllEntities2())
            {
                var patient = new Patient
                {
                    FirstName = "Andrew",
                    LastName = "Doe",
                    Email = "john@gmail.com",
                    PhoneNumer = "0754511254",
                };
                var room = new Room
                {
                    Name = "Internal med room"
                };


                var appoinment = new Appointment
                {
                    Date = "12345",
                };
                appoinment.Room = room;

                var doctor = new Doctor
                {
                    FirstName = "Joe",
                    LastName = "jones",
                    Email = "sam@gmail.com",
                    PhoneNumber = "1234564784",
                    Specialization = "internal medicine"
                };

                doctor.Rooms.Add(room);
                doctor.Appointment = appoinment;
                //appoinment.Doctor = doctor;
                patient.Appointment = appoinment;
                patient.Doctors.Add(doctor);
                //appoinment.Patient = patient;
                //doctor.Patients.Add(patient);
                context.Appointments.Add(appoinment);
                context.Patients.Add(patient);

                context.Doctors.Add(doctor);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    Console.WriteLine(e);
                    throw;
                }


            }
        }
    }
}
