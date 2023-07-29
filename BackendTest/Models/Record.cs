using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Models
{
    public class Record
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }

        #region GetColumnValue
        public string GetColumnValue(int columnNumber)
        {
            switch (columnNumber)
            {
                case 1:
                    return Id;
                case 2:
                    return LastName;
                case 3:
                    return FirstName;
                case 4:
                    return BirthDate;
                default:
                    return string.Empty;
            }
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"{Id},{LastName},{FirstName},{BirthDate}";
        }
        #endregion

    }
}
