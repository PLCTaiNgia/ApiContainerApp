using ApiContainer.Dto;
using ApiContainer.Repositories.BookingRepository;

namespace ApiContainer.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public bool AddBooking(int userId, AddBookingDto addBookingDto)
        {
            return bookingRepository.Create(userId, addBookingDto);
        }

        public List<Models.Booking> GetListBooking()
        {
            return bookingRepository.FindAll();
        }

        public List<Models.Booking> GetListBookingByUserId(int userId)
        {
            return bookingRepository.FindByUserId(userId);
        }
    }
}
