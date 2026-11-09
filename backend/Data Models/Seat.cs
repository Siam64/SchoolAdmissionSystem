namespace SchoolAdmissionSystem.Data_Models
{
    public class Seat
    {
        public int Id { get; set; }

        public string SeatNumber { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;
    }
}
