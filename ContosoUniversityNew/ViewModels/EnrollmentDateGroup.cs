using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversityNew.ViewsModels
{
    public class EnrollmentDataGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}