using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace CSCI_3600_Group_Project.Models
{
    public class FileModel
    {
        private readonly string[] _picture =
        {
            ".PNG", ".JPG", ".JPEG", ".BMP", ".GIF"
        };

        private readonly string[] _audio =
        {
            ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA"
        };

        private readonly string[] _video =
        {
            ".AVI", ".MP4", ".DIVX", ".WMV"
        };

        public FileModel()
        {
        }
        public string FontAwesomeFileType
        {
            get { return this.FontAwesomeFileType; }
            set
            {
                if (_picture.Contains(value.ToUpper()))
                {
                    this.FontAwesomeFileType = "file-image";
                }
                else if (_audio.Contains(value.ToUpper()))
                {
                    this.FontAwesomeFileType = "file-audio";
                }
            }
            
        }

        public string FileType { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime LastModified { get; set; }
        public long Size { get; set; }
    }
}