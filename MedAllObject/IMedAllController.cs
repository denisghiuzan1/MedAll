using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MedAll;

namespace MedAllObject
{
    [ServiceContract]
    public interface IMedAllController
    {
        [OperationContract]
        void AddPatient(Patient patient);

        [OperationContract]
        List<Patient> GetAllPatients();
        [OperationContract]
        Patient GetPatient(string searchString);
        [OperationContract]
        void AddDoctor(Doctor doctor);
        [OperationContract]
        List<Doctor> GetAllDoctors();
        [OperationContract]
        List<Room> GetDoctorRooms(string searchString);
        [OperationContract]
        Room GetRoom(string searchString);
        [OperationContract]
        Doctor GetDoctor(string searchString);
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        User GetUser(string email, string password);
        [OperationContract]
        Role GetUserRole(string email, string password);
        [OperationContract]
        void UpdateUserPassword(string email, string password);
        [OperationContract]
        void AddRole(Role role);
        [OperationContract]
        void AddAdmin(Admin admin);
        [OperationContract]
        void AddAppointment(Appointment app);
        [OperationContract]
        List<Appointment> GetAllAppointments();
    }
}
