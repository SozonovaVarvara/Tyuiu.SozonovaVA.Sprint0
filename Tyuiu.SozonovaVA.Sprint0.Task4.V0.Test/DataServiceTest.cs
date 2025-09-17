using Tyuiu.SozonovaVA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SozonovaVA.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckAdditionValid()
        {
            Assert.Equal(10, DataService.Addition(5, 5));
        }
        public void CheckSubtractionValid()
        {
            Assert.Equal(5, DataService.Subtraction(10, 5));
        }

        public void CheckMultiplicationValid()
        {
            Assert.Equal(50, DataService.Multiplication(10, 5));
        }

        public void CheckDivisionValid()
        {
            Assert.Equal(3, DataService.Division(9, 3));
        }
    }

}
