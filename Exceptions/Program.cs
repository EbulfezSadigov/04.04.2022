using Exceptions.Models;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Room room = new Room("411", 400, 4, 5);
                room.ShowInfo();
                Hotel hot = new Hotel("Capital", 10);
            }
            catch (NotFoundException ex)
            {
                throw ex;
            }
            catch (NotAvailableException ex2)
            {
                throw ex2;
            }
        }
    }
}
