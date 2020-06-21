using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAll.Model;

namespace MedAll
{
    public partial class AdminForm : Form
    {
        private DBController dbController;
        private List<Patient> patients;
        private List<Doctor> doctors;
        public AdminForm()
        {
            InitializeComponent();
            dbController=new DBController();
            patients = dbController.GetAllPatients();
            doctors = dbController.GetAllDoctors();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            resetElementsVisibility(false);
            ResetAddAppointmentElementsVisibility(true);
            foreach (var patient in patients) patientComboBox.Items.Add(patient.FirstName + " " +patient.LastName);
            foreach (var doctor in doctors) doctorComboBox.Items.Add(doctor.FirstName + " " + doctor.LastName);
        }

        private void resetElementsVisibility(bool status)
        {
            addUserButton.Visible = status;
            searchButton.Visible = status;
        }

        private void ResetAddAppointmentElementsVisibility(bool status)
        {
            patientLabel.Visible = status;
            patientComboBox.Visible = status;
            doctorLabel.Visible = status;
            doctorComboBox.Visible = status;
            roomLabel.Visible = status;
            roomComboBox.Visible = status;
            dateLabel.Visible = status;
            appointmentDatePicker.Visible = status;
            saveAppointmentButton.Visible = status;
            scheduleTextBox.Visible = status;
            scheduleLabel.Visible = status;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ResetAddAppointmentElementsVisibility(false);
        }

        private void scheduleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetElementsVisibility(true);
            ResetAddAppointmentElementsVisibility(false);
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDoctor = doctorComboBox.SelectedItem.ToString();
            var rooms = dbController.GetDoctorRooms(selectedDoctor);
            foreach (var room in rooms)
            {
                roomComboBox.Items.Add(room.Name);
            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveAppointmentButton_Click(object sender, EventArgs e)
        {
            dbController.AddAppointment(new Appointment
            {
                Date = appointmentDatePicker.Text + " " + scheduleTextBox.Text,
                Doctor = dbController.GetDoctor(doctorComboBox.SelectedItem.ToString()),
                Patient = dbController.GetPatient(patientComboBox.SelectedItem.ToString()),
                Room = dbController.GetRoom(roomComboBox.SelectedItem.ToString())
            });
        }
    }
}
