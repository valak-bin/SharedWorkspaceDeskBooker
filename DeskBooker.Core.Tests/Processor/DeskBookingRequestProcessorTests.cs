using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValues()
        {
            // Arrange
            var request = new DeskBookingRequest
            {
                FirstName = "Jered",
                LastName = "Sanchez",
                Email = "valak@aol.com",
                Date = new DateTime(2022, 6, 15)
            };

            var processor = new DeskBookingRequestProcessor();
            
            // Act
            DeskBookingResult result = processor.BookDesk(request);

            // Assert
            Assert.NotNull(result);
            
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }
    }
}
