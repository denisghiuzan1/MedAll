using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAll.Model
{
    public class DBController
    {
        public void AddPatient(Patient patient)
        {
            using (var context = new MedAllEntities2())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }

        public List<Patient> GetAllPatients()
        {
            using (var context = new MedAllEntities2())
            {
                return context.Patients.ToList();
            }
        }

        public Patient GetPatient(string searchString)
        {
            using (var context = new MedAllEntities2())
            {
                foreach (var patient in context.Patients)
                {
                    var patientFullName = patient.FirstName + " " + patient.LastName;
                    if (patientFullName.Contains(searchString))
                    {
                        return patient;
                    }
                }
            }

            return null;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var context = new MedAllEntities2())
            {
                context.Doctors.Add(doctor);
                context.SaveChanges();
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            using (var context = new MedAllEntities2())
            {
                return context.Doctors.ToList();
            }
        }
        public List<Room> GetDoctorRooms(string searchString)
        {
            using (var context = new MedAllEntities2())
            {
                var doctors = context.Doctors;
                foreach (var doc in doctors)
                {
                    var doctorFullName = doc.FirstName + " " + doc.LastName;
                    if (doctorFullName.Contains(searchString)
                    )
                    {
                        return doc.Rooms.ToList();
                    }
                }
            }

            return null;
        }

        public Room GetRoom(string searchString)
        {
            using (var context = new MedAllEntities2())
            {
                var rooms = context.Rooms;
                foreach (var room in rooms)
                {

                    if (room.Name.Contains(searchString)
                    )
                    {
                        return room;
                    }
                }
            }

            return null;
        }

        public Doctor GetDoctor(string searchString)
        {
            using (var context = new MedAllEntities2())
            {
                var doctors = context.Doctors;
                foreach (var doc in doctors)
                {
                    var doctorFullName = doc.FirstName + " " + doc.LastName;
                    if (doctorFullName.Contains(searchString)
                    )
                    {
                        return doc;
                    }
                }
            }

            return null;
        }
        public void AddUser(User user)
        {
            using (var context = new MedAllEntities2())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User GetUser(string email, string password)
        {
            using (var context = new MedAllEntities2())
            {
                foreach (var user in context.Users)
                {
                    if (user.Email.Equals(email)
                    && user.Password.Equals(password))
                    {
                        return user;
                    }
                }
            }

            return null;
        }
        public Role GetUserRole(string email, string password)
        {
            using (var context = new MedAllEntities2())
            {
                foreach (var user in context.Users)
                {
                    if (user.Email.Equals(email)
                        && user.Password.Equals(password))
                    {
                        return user.Role;
                    }
                }
            }

            return null;
        }

        public void UpdateUserPassword(string email, string password)
        {
            var user = new User {Email = email, Password = password};

            using (var context = new MedAllEntities2())
            {
                context.Users.Attach(user);
                context.Entry(user).Property(x => x.Password).IsModified = true;
                context.SaveChanges();
            }
        }

        public void AddRole(Role role)
        {
            using (var context = new MedAllEntities2())
            {
                context.Roles.Add(role);
                context.SaveChanges();
            }
        }


        public void AddAdmin(Admin admin)
        {
            using (var context = new MedAllEntities2())
            {
                context.Admins.Add(admin);
                context.SaveChanges();
            }
        }

        public void AddAppointment(Appointment app)
        {
            using (var context = new MedAllEntities2())
            {
                context.Appointments.Add(app);
                context.SaveChanges();
            }
        }
        public List<Appointment> GetAllAppointments()
        {
            using (var context = new MedAllEntities2())
            {
                return context.Appointments.ToList();
            }
        }
    }
}
