using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MedAll;

namespace MedAllClient
{
    public partial class AdminForm : Form
    {
        private MedAllControllerClient medAllControllerClient;
        private List<Patient> patients;
        private List<Doctor> doctors;
        public AdminForm()
        {
            InitializeComponent();
            medAllControllerClient=new MedAllControllerClient();
            patients = medAllControllerClient.GetAllPatients().ToList();
            doctors = medAllControllerClient.GetAllDoctors().ToList();
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
            var rooms = medAllControllerClient.GetDoctorRooms(selectedDoctor);
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
            medAllControllerClient.AddAppointment(new Appointment
            {
                Date = appointmentDatePicker.Text + " " + scheduleTextBox.Text,
                Doctor = medAllControllerClient.GetDoctor(doctorComboBox.SelectedItem.ToString()),
                Patient = medAllControllerClient.GetPatient(patientComboBox.SelectedItem.ToString()),
                Room = medAllControllerClient.GetRoom(roomComboBox.SelectedItem.ToString())
            });
        }
    }
}
