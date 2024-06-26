﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace IssueTracker.Models.ViewModels
{
    public class AssignDeveloperViewModel
    {
        public Ticket Ticket { get; set; }

        public SelectList Developers { get; set; }

        public string DeveloperId { get; set; }
    }
}
