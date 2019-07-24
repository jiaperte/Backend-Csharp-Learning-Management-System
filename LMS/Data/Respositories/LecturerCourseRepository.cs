﻿using Data.Database;
using Data.Respositories.Interfaces;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Respositories
{
    public class LecturerCourseRepository : GenericRepository<LecturerCourse>, ILecturerCourseRepository
    {
        public LecturerCourseRepository(LMSEntities context) : base(context)
        {
        }
    }
}
