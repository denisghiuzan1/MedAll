using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAll;
using MedAll.Model;

namespace MedAllObject
{
    public class MedAllController : IMedAllController
    {
        private readonly DBController dbController;

        public MedAllController()
        {
            this.dbController = new DBController();
        }

        public void AddPatient(Patient patient)
        {
            dbController.AddPatient(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return dbController.GetAllPatients();
        }

        public Patient GetPatient(string searchString)
        {
            return dbController.GetPatient(searchString);
        }

        public void AddDoctor(Doctor doctor)
        {
            dbController.AddDoctor(doctor);
        }

        public List<Doctor> GetAllDoctors()
        {
            return dbController.GetAllDoctors();
        }

        public List<Room> GetDoctorRooms(string searchString)
        {
            return dbController.GetDoctorRooms(searchString);
        }

        public Room GetRoom(string searchString)
        {
            return dbController.GetRoom(searchString);
        }

        public Doctor GetDoctor(string searchString)
        {
            return dbController.GetDoctor(searchString);
        }

        public void AddUser(User user)
        {
            dbController.AddUser(user);
        }

        public User GetUser(string email, string password)
        {
            return dbController.GetUser(email, password);
        }

        public Role GetUserRole(string email, string password)
        {
            return dbController.GetUserRole(email, password);
        }

        public void UpdateUserPassword(string email, string password)
        {
            dbController.UpdateUserPassword(email, password);
        }

        public void AddRole(Role role)
        {
            dbController.AddRole(role);
        }

        public void AddAdmin(Admin admin)
        {
            dbController.AddAdmin(admin);
        }

        public void AddAppointment(Appointment app)
        {
            dbController.AddAppointment(app);
        }

        public List<Appointment> GetAllAppointments()
        {
            return dbController.GetAllAppointments();
        }
    }
}
