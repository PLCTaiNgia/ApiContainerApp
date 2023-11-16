using ApiContainer.Dto;

namespace ApiContainer.Services.Booking
{
    public interface IBookingService
    {
        List<ApiContainer.Models.Booking> GetListBooking();
        Boolean AddBooking(int userId, AddBookingDto addBookingDto);
        List<Models.Booking> GetListBookingByUserId(int userId);
        bool DeleteBookingById(int userId, string bookingId);
    }
}
