using ApiContainer.Dto;
using ApiContainer.Models;

namespace ApiContainer.Repositories.BookingRepository
{
    public interface IBookingRepository
    {
        List<Booking> FindAll();
        Boolean Create(int userId, AddBookingDto addBookingDto);
        List<Booking> FindByUserId(int userId);
        bool Delete(int userId, string bookingId);
    }
}
