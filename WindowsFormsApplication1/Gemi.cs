﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace WindowsFormsApplication1
{
   public class Gemi
    {
      public  int guvenli_alan;
      public int hiz;
      public int yon;
      public Point merkez;
        public Gemi(int guvenli_alan, int hiz, int yon, Point merkez)
        {
            this.guvenli_alan = guvenli_alan;
            this.hiz = hiz;
            this.yon = yon;
            this.merkez = merkez;
           
        }

        public int getGuvenli_alan()
        {
            return this.guvenli_alan;
        }
        public void setGuvenli_alan(int guvenli_alan)
        {
            this.guvenli_alan = guvenli_alan;
        }

        public int getHiz()
        {
            return this.hiz;
        }
        public void setHiz(int hiz)
        {
            this.hiz = hiz;
        }

        public int getYon()
        {
            return this.yon;
        }
        public void setYon(int yon)
        {
            this.yon = yon;
        }

        public void gemiIlerle(int yon, int hiz)
        {

        }
        

    }
}
