
using Tyuiu.SozonovaVA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.SozonovaVA.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckValid()
        {
            Assert.Equal(10, DataService.Sum(5, 5));
        }
    }
}