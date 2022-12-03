﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IssueTracker.Models
{
    public class BTUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile AvatarFormFile { get; set; }

        [DisplayName("Avatar")]
        public string AvatarFormName { get; set; }
        public byte[] AvatarFileData { get; set; }

        [Display(Name = "File Extension")]
        public string AvatarContentType { get; set; }

        public int? CompanyId { get; set; }


        // -- Nav properties create relationships between tables and models. --//
        // -- Creates a Many to Many relationship between Projects and Members to create a JOIN table.

        public virtual Company Company { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

    }
}
