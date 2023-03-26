using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruongDangKhoa_2011061614.Models;

namespace TruongDangKhoa_2011061614.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}