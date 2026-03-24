// See https://aka.ms/new-console-template for more information

using APBD_Cw2_s33681;
using APBD_Cw2_s33681.Users;

class Program
{
    static void Main(string[] args)
    {
        var service = new Service();
        service.setPenaltyRate(5);
        var laptop = new Laptop("i7-7700K", 24);
        var camera = new Camera(24, "1920x1080");
        var projector = new Projector(400, "FHD 1920x1080");
        service.AddDevice(laptop);
        service.AddDevice(camera);
        service.AddDevice(projector);
        
        
        var student = new Student("Maciej", "Owczarski", "s33681", 4);
        var lekturer = new Lecturer("Jan", "Kowalski", "Profesor", "Katedra programowania", "Wykładowca");
        service.AddPerson(student);
        service.AddPerson(lekturer);
        
        service.BorrowDevice(1, 1);
        //service.BorrowDevice(2, 1);
        
        
        service.ShowAllDevices();
        service.ReturnDevice(1, 1);
        service.ShowAvailableDevices();
        
        service.BorrowDevice(2, 2);

        service.GetWypozyczenie(2, 2).Due = DateTime.Now.AddDays(-5);
        
        service.ReturnDevice(2, 2);
        
        
        projector.Unavailable();
        
        service.Raport();
        
        
        service.ShowWypozyczenia(1);
        
        service.ShowOutdatedWypozyczenia();
        
       // service.Raport();
        
        
    }
}