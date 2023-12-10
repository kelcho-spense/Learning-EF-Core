// See https://aka.ms/new-console-template for more information
using hospitalMSCA.Data;
using hospitalMSCA.Models;
using Microsoft.EntityFrameworkCore;

using hospitalMSDBContext context =  new hospitalMSDBContext();

// CREATE ROOMS

//List<Room> ListOfRooms = new List<Room>()
//{
//    new Room { RoomNumber = "101", RoomType = "Single" },
//    new Room { RoomNumber = "102", RoomType = "Single" },
//    new Room { RoomNumber = "103", RoomType = "Single" },
//    new Room { RoomNumber = "104", RoomType = "Single" },
//    new Room { RoomNumber = "105", RoomType = "Single" },
//    new Room { RoomNumber = "106", RoomType = "Single" },
//    new Room { RoomNumber = "107", RoomType = "Single" },
//    new Room { RoomNumber = "108", RoomType = "Double" },
//    new Room { RoomNumber = "109", RoomType = "Double" },
//    new Room { RoomNumber = "110", RoomType = "Double" },
//    new Room { RoomNumber = "111", RoomType = "Double" },
//    new Room { RoomNumber = "112", RoomType = "Tripple" },
//    new Room { RoomNumber = "113", RoomType = "Tripple" },
//    new Room { RoomNumber = "114", RoomType = "Tripple" },
//    new Room { RoomNumber = "115", RoomType = "Tripple" },
//    new Room { RoomNumber = "116", RoomType = "Tripple" },
//    new Room { RoomNumber = "117", RoomType = "Tripple" },
//    new Room { RoomNumber = "118", RoomType = "Tripple" },
//    new Room { RoomNumber = "119", RoomType = "Tripple" },
//    new Room { RoomNumber = "120", RoomType = "Tripple" },
//    new Room { RoomNumber = "121", RoomType = "Tripple" },
//    new Room { RoomNumber = "122", RoomType = "Tripple" },
//    new Room { RoomNumber = "123", RoomType = "Double" },
//    new Room { RoomNumber = "124", RoomType = "Double" },
//    new Room { RoomNumber = "125", RoomType = "Double" },
//    new Room { RoomNumber = "126", RoomType = "Double" },
//    new Room { RoomNumber = "127", RoomType = "Double" },
//    new Room { RoomNumber = "128", RoomType = "Double" },
//    new Room { RoomNumber = "129", RoomType = "Double"}
//};

//context.Rooms.AddRange(ListOfRooms);
//context.SaveChanges();

//LIST BY GROUPING THE NUMBER OF ROOMS PER ROOM TYPE
// LINQ
//var roomsgroupedbyroomTypes = from room in context.Rooms
//        group room by room.RoomType 
//        into roomGroup
//        orderby roomGroup.Key
//    select new { roomGroup.Key, Count = roomGroup.Count()};

//foreach (var room in roomsgroupedbyroomTypes)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine($"Room Type: {room.Key} - Number of Rooms: {room.Count}");
//    Console.WriteLine(new string('-', 100));
//}

//CREATE PATIENTS

//List<Patient> ListOfPatients = new List<Patient>()
//{
//    new Patient { FirstName = "Bob", LastName = "Smith", Email = "bob@mail.com", RoomId = 1},
//    new Patient { FirstName = "John", LastName = "Doe", Email = "john@mail.com", RoomId = 2},
//    new Patient { FirstName = "Jane", LastName = "Doe", Email = "jane@mail.com", RoomId = 3},
//    new Patient { FirstName = "Sally", LastName = "Smith", Email = "sally@mail.com", RoomId = 4},
//    new Patient { FirstName = "Sally", LastName = "Smith", Email = "sally1@mail.com", RoomId = 4 },
//    new Patient { FirstName = "John", LastName = "Doe", Email = "john.doe@mail.com", RoomId = 5 },
//    new Patient { FirstName = "Emily", LastName = "Johnson", Email = "emily.johnson@mail.com", RoomId = 6 },
//    new Patient { FirstName = "Daniel", LastName = "Miller", Email = "daniel.miller@mail.com", RoomId = 7 },
//    new Patient { FirstName = "Grace", LastName = "Brown", Email = "grace.brown@mail.com", RoomId = 8 },
//    new Patient { FirstName = "Michael", LastName = "Clark", Email = "michael.clark@mail.com", RoomId = 9 },
//    new Patient { FirstName = "Olivia", LastName = "Davis", Email = "olivia.davis@mail.com", RoomId = 10 },
//    new Patient { FirstName = "William", LastName = "White", Email = "william.white@mail.com", RoomId = 11 },
//    new Patient { FirstName = "Ava", LastName = "Moore", Email = "ava.moore@mail.com", RoomId = 12 },
//    new Patient { FirstName = "James", LastName = "Wilson", Email = "james.wilson@mail.com", RoomId = 13 },
//    new Patient { FirstName = "Sophia", LastName = "Taylor", Email = "sophia.taylor@mail.com", RoomId = 14 }
//};

//context.Patients.AddRange(ListOfPatients);
//context.SaveChanges();

// SELECT PATIENTS
//var patients = from patient in context.Patients
//               select patient;
//foreach (var patient in patients)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine($"Patient: {patient.FirstName} {patient.LastName} - and Email : {patient.Email}");
//    Console.WriteLine(new string('-', 100));
//}

//SELECT PATIENTS AND ROOMS

//var patients = from patient in context.Patients
//               .Include(p => p.Room)
//                select patient;

//foreach (var patient in patients)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine($"Patient: {patient.FirstName} {patient.LastName} - and Email : {patient.Email} Room Number : {patient.Room.RoomNumber} Room Type : {patient.Room.RoomType}");
//    Console.WriteLine(new string('-', 100));
//}

//CREATE DOCTORS

//List<Doctor> ListOfDoctors = new List<Doctor>()
//{
//    new Doctor { DoctorName = "Bob Smith", Speciality = "Cardiologist" },
//    new Doctor { DoctorName = "Alice Johnson", Speciality = "Neurologist" },
//    new Doctor { DoctorName = "David Miller", Speciality = "Orthopedic Surgeon" },
//    new Doctor { DoctorName = "Emily Jones", Speciality = "Dermatologist" },
//    new Doctor { DoctorName = "Michael Clark", Speciality = "Pediatrician" },
//    new Doctor { DoctorName = "Olivia Brown", Speciality = "Ophthalmologist" },
//    new Doctor { DoctorName = "Daniel Davis", Speciality = "Gastroenterologist" },
//    new Doctor { DoctorName = "Sophia White", Speciality = "Pulmonologist" },
//    new Doctor { DoctorName = "Matthew Moore", Speciality = "Endocrinologist" },
//    new Doctor { DoctorName = "Ava Wilson", Speciality = "Rheumatologist" },
//    new Doctor { DoctorName = "William Taylor", Speciality = "Psychiatrist" },
//    new Doctor { DoctorName = "Ella Anderson", Speciality = "Urologist" },
//    new Doctor { DoctorName = "James Smith", Speciality = "Hematologist" },
//    new Doctor { DoctorName = "Grace Martin", Speciality = "Allergist" },
//    new Doctor { DoctorName = "Benjamin Lewis", Speciality = "Nephrologist" }
//};

//context.Doctors.AddRange(ListOfDoctors);
//context.SaveChanges();

// SELECT DOCTORS
//var doctors = from doctor in context.Doctors
//              select doctor;
//foreach (var doctor in doctors)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine($"Doctor: {doctor.DoctorName} - and Speciality : {doctor.Speciality}");
//    Console.WriteLine(new string('-', 100));
//}

//CREATE APPOINTMENTS

//List<Appointment> Appointments = new List<Appointment>()
//{
//    new Appointment { AppointmentDate = DateTime.Today.ToShortDateString(), PatientId = 1, DoctorId = 1,AppointmentTime = DateTime.Today.ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(1).ToShortDateString(), PatientId = 1, DoctorId = 1, AppointmentTime = DateTime.Today.AddHours(14).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(2).ToShortDateString(), PatientId = 2, DoctorId = 2, AppointmentTime = DateTime.Today.AddHours(15).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(3).ToShortDateString(), PatientId = 3, DoctorId = 3, AppointmentTime = DateTime.Today.AddHours(16).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(4).ToShortDateString(), PatientId = 4, DoctorId = 4, AppointmentTime = DateTime.Today.AddHours(17).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(5).ToShortDateString(), PatientId = 5, DoctorId = 5, AppointmentTime = DateTime.Today.AddHours(18).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(6).ToShortDateString(), PatientId = 6, DoctorId = 6, AppointmentTime = DateTime.Today.AddHours(9).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(7).ToShortDateString(), PatientId = 7, DoctorId = 7, AppointmentTime = DateTime.Today.AddHours(10).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(8).ToShortDateString(), PatientId = 8, DoctorId = 8, AppointmentTime = DateTime.Today.AddHours(11).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(9).ToShortDateString(), PatientId = 9, DoctorId = 9, AppointmentTime = DateTime.Today.AddHours(13).ToShortTimeString() },
//    new Appointment { AppointmentDate = DateTime.Today.AddDays(10).ToShortDateString(), PatientId = 10, DoctorId = 10, AppointmentTime = DateTime.Today.AddHours(14).ToShortTimeString() }
//};

//context.Appointments.AddRange(Appointments);
//context.SaveChanges();

// SELECT APPOINTMENTS WITH PATIENTS AND DOCTORS
try {
    var appointments = from appointment in context.Appointments
                       .Include(a => a.Patient)
                       .Include(a => a.Doctor)
                       select appointment;
    foreach (var appointment in appointments)
    {
        Console.WriteLine(new string('-', 100));

        Console.WriteLine($"Patient : {appointment.Patient.FirstName} {appointment.Patient.LastName} has an appointment at Date: {appointment.AppointmentDate} - and Appointment Time : {appointment.AppointmentTime} with  Doctor : {appointment.Doctor.DoctorName}");
       
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
