﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DvdRental.Core.Components;

namespace DvdRental.Core.Models
{
    public class Dvd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ReleaseYear { get; set; }
        public string Description { get; set; }
        public int Genre { get; set; }
        public byte[] Poster { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public void SetPoster(Image img)
        {
            if (img == null) return;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            Poster = ms.ToArray();
        }

        public Image GetPoster()
        {
            if (Poster != null) 
            {
                var ms = new MemoryStream();
                ms.Write(Poster, 0, Poster.Length);
                return Image.FromStream(ms);
            }
            return null;
        }

        public void SetId()
        {
            Id = Database.GetNextID<Dvd>();
            IsNew = true;
        }

        public bool IsNew = false;

        public bool Search(string text)
        {
            var result = Title.IndexOf(text) != -1 ||
                ReleaseYear.ToString().IndexOf(text) != -1 ||
                Description.IndexOf(text) != -1;
            return result;
        }


    }
}
