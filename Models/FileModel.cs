using System;
using Microsoft.AspNetCore.Identity;

namespace CSCI_3600_Group_Project.Models
{
    public class FileModel
    {
        public string FileType { get; set; }
        public string Name { get; set; }
        public IdentityUser OwnerI { get; set; }
        public string Owner { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public int Size { get; set; }
    }
}