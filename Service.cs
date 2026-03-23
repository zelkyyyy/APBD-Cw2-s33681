using APBD_Cw2_s33681.Users;

namespace APBD_Cw2_s33681;

public class Service
{
    private List<Device>  _devices = new List<Device>();
    private List<Person> _persons = new List<Person>();
    private List<Wypozyczenie> _wypozyczenia = new List<Wypozyczenie>();
    public double PenaltyRate { get; set; }
    
    

    public void AddPerson(Person person)
    {
        this._persons.Add(person);
    }

    public void AddDevice(Device device)
    {
        this._devices.Add(device);
    }

    public void setPenaltyRate(double penaltyRate)
    {
        this.PenaltyRate = penaltyRate;
    }
    public void BorrowDevice(int personId, int deviceId)
    {
        var person = _persons.FirstOrDefault(p => p.Id == personId);
        var device = _devices.FirstOrDefault(d => d.Id == deviceId);
        if (person is null)
        {
            throw new Exception($"Person {personId} not found");
        }

        if (device is null)
        {
            throw new Exception($"Device {deviceId} not found");
        }

        if (!device.IsAvailable)
        {
            throw new Exception($"Device {deviceId} not available");
        }
        
        if (person.Kara > 0)
            throw new Exception($"Person {personId} has some penalties to pay.");
        
        var count = _wypozyczenia.Count(r => r.Kto.Id == personId && r.Zwrot == null);
        if (count >= person.WypozyczeniaLimit)
        {
            throw new Exception($"{personId} has reached limit");
        }
        
        device.IsAvailable = false;
        _wypozyczenia.Add(new Wypozyczenie(device, person));
        
        Console.WriteLine($"Pomyślnie wypożyczono {device.Name} dla {person.FirstName} {person.LastName}");
        
    }
    
    public void ReturnDevice(int personId, int deviceId)
    {
        var person = _persons.FirstOrDefault(p => p.Id == personId);
        var device = _devices.FirstOrDefault(d => d.Id == deviceId);
        var wypo = _wypozyczenia.FirstOrDefault(w => w.Kto == person && w.Co == device && w.Zwrot == null);
        if (wypo is null)
        {
            throw new Exception($"Wypozyczenie not found");
        }
        
        wypo.Co.IsAvailable = true;
        wypo.Zwrot = DateTime.Now;
        
        var ile = wypo.Zwrot.Value - wypo.Due;
        
        if (ile.TotalDays > 0 && person != null)
            person.Kara += Math.Ceiling(ile.TotalDays) * PenaltyRate;
    }

    public void ShowAllDevices()
    {
        foreach (var device in _devices)
        {
            Console.WriteLine(device);
        }
    }

    public void ShowAvailableDevices()
    {
        foreach (var device in _devices)
        {
            if (device.IsAvailable)
                Console.WriteLine(device);
        }
    }

    public void ShowWypozyczenia(int personId)
    {
        var person = _persons.FirstOrDefault(p => p.Id == personId);
        if (person is null)
        {
            throw new Exception($"Person {personId} not found");
        }
        
        foreach (var wypo in _wypozyczenia)
        {
            if (wypo.Kto.Id == person.Id)
                {
                Console.WriteLine(wypo);
                }
        }
    }

    public void showOutdatedWypozyczenia()
    {
        foreach (var wypo in _wypozyczenia)
            {
                if (wypo.WTerminie == false)
                {
                    Console.WriteLine(wypo);
                }
            }
    }
    
    public void Raport()
    {
       Console.WriteLine("Raport");
       Console.WriteLine($"Ilość sprzętu: {_devices.Count}");
       Console.WriteLine($"Dostępny sprzęt: {_devices.Count(d => d.IsAvailable)}");
       Console.WriteLine($"Osoby ktore wypozyczyly: ");
       foreach (var person in _persons)
       {
           Console.WriteLine($"{person.FirstName} {person.LastName}");
       }
       Console.WriteLine($"łączna suma kar: {_persons.Sum(p => p.Kara)}");
    }
    
}