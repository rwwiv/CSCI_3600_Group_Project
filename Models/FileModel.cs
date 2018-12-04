using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace CSCI_3600_Group_Project.Models
{
    public class FileModel
    {
        private readonly string[] _picture = { ".PNG", ".JPG", ".JPEG", ".BMP", ".GIF"};
        private readonly string[] _audio = { ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA" };
        private readonly string[] _video = { ".AVI", ".MP4", ".DIVX", ".WMV" };
        private readonly string[] _doc = {".DOC",".DOCX",".ODT"};
        private readonly string[] _spreadsheet = {".XLS","XLSX",".ODS"};
        private readonly string[] _powerpoint = {".PPT", ".PPTX", ".ODP"};
        private string _fontAwesomeFileType;
        public FileModel()
        {
        }
        public string FontAwesomeFileType
        {
            get => _fontAwesomeFileType;
            set
            {
                if (_picture.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-image";
                }
                else if (_audio.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-audio";
                }
                else if (_video.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-video";
                }
                else if (_doc.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-word";
                }
                else if (_spreadsheet.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-excel";
                }
                else if (_powerpoint.Contains(value.ToUpper()))
                {
                    _fontAwesomeFileType = "file-powerpoint";
                }
                else if (value.Equals(".txt"))
                {
                    _fontAwesomeFileType = "file-alt";
                }
                else
                {
                    _fontAwesomeFileType = "file";
                }
            }
            
        }

        public string FileType { get; set; }

        private string _displayName;
        public string DisplayName
        {
            get => _displayName;
            set
            {
                if (value.Length > 20)
                {
                    _displayName = value.Substring(0, 20)+"...";
                }
                else
                {
                    _displayName = value;
                }
            }
        }
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime LastModified { get; set; }
        public long Size { get; set; }
    }
}