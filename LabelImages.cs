using ADR_Cursus.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    public class LabelImages
    {
        public static _LabelImage Image1 = new()
        {
            Image = Resources.k1_1,
            Name = "k1_1"
        };
        public static _LabelImage Image2 = new()
        {
            Image = Resources.k1_2,
            Name = "k1_2"
        };
        public static _LabelImage Image3 = new()
        {
            Image = Resources.k1_3,
            Name = "k1_3"
        };
        public static _LabelImage Image4 = new()
        {
            Image = Resources.k1_4,
            Name = "k1_4"
        };
        public static _LabelImage Image5 = new()
        {
            Image = Resources.k2_1,
            Name = "k2.1_1"
        };
        public static _LabelImage Image6 = new()
        {
            Image = Resources.k2_2,
            Name = "k2.1_2"
        };
        public static _LabelImage Image7 = new()
        {
            Image = Resources.k3_1,
            Name = "k2.2_1"
        };
        public static _LabelImage Image8 = new()
        {
            Image = Resources.k3_2,
            Name = "k2.2_2"
        };
        public static _LabelImage Image9 = new()
        {
            Image = Resources.k4,
            Name = "k2.3"
        };
        public static _LabelImage Image10 = new()
        {
            Image = Resources.k5_1,
            Name = "k3_1"
        };
        public static _LabelImage Image11 = new()
        {
            Image = Resources.k5_2,
            Name = "k3_2"
        };
        public static _LabelImage Image12 = new()
        {
            Image = Resources.k6,
            Name = "k4.1"
        };
        public static _LabelImage Image13 = new()
        {
            Image = Resources.k7,
            Name = "k4.2"
        };
        public static _LabelImage Image14 = new()
        {
            Image = Resources.k8,
            Name = "k4.3"
        };
        public static _LabelImage Image15 = new()
        {
            Image = Resources.k9,
            Name = "k5.1"
        };
        public static _LabelImage Image16 = new()
        {
            Image = Resources.k10,
            Name = "k5.2"
        };
        public static _LabelImage Image17 = new()
        {
            Image = Resources.k11,
            Name = "k6.1"
        };
        public static _LabelImage Image18 = new()
        {
            Image = Resources.k12,
            Name = "k6.2"
        };
        public static _LabelImage Image19 = new()
        {
            Image = Resources.k13_1,
            Name = "k7_1"
        };
        public static _LabelImage Image20 = new()
        {
            Image = Resources.k13_2,
            Name = "k7_2"
        };
        public static _LabelImage Image21 = new()
        {
            Image = Resources.k13_3,
            Name = "k7_3"
        };
        public static _LabelImage Image22 = new()
        {
            Image = Resources.k13_4,
            Name = "k7_4"
        };
        public static _LabelImage Image23 = new()
        {
            Image = Resources.k13_5,
            Name = "k7_5"
        };
        public static _LabelImage Image24 = new()
        {
            Image = Resources.k14,
            Name = "k8"
        };
        public static _LabelImage Image25 = new()
        {
            Image = Resources.k15,
            Name = "k9"
        };

        public static readonly IEnumerable<_LabelImage> LabelImagesList = new List<_LabelImage>()
        {
            Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9, Image10, 
            Image11, Image12, Image13, Image14, Image15, Image16, Image17, Image18, Image19, Image20,
            Image21, Image22, Image23, Image24, Image25,
        };
        public static Image GetImageFromName(string name)
        {
            return LabelImagesList
                .Where(i => i.Name == name)
                .Select(i => i.Image)
                .First();
        }
    }
    }

    public class _LabelImage
    {
        public Image Image;
        public string Name;
    }

