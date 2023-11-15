using ApiContainer.Dto;
using ApiContainer.Models;

namespace ApiContainer.Repositories.BookingRepository
{
    public class BookingRepository : IBookingRepository
    {
        public bool Create(int userId, AddBookingDto addBookingDto)
        {
            var booking = new Booking
            {
                Id = Guid.NewGuid().ToString(),
                ContainerId = addBookingDto.ContainerId,
                UserId = userId,
                User = Data.users.FirstOrDefault(u => u.Id == userId),
                Container = Data.Containers.FirstOrDefault(c => c.CntrNo == addBookingDto.ContainerId)
            };

            Data.bookings.Add(booking);

            return true;
        }

        public List<Booking> FindAll()
        {
            var data = Data.bookings;
            return Data.bookings;
        }

        public List<Booking> FindByUserId(int userId)
        {
            var data = Data.bookings.Where(x => x.UserId == userId).ToList();
            return data;
        }
    }
}
