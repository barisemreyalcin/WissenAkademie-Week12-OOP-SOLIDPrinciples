﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosePrinciple.OCP.CustomExceptions;

namespace OpenClosePrinciple.OCP
{
    public class MotorServisi
    {
        private IDepoServisi depoServisi;

        public MotorServisi()
        {
            depoServisi = new DepoServisi();    
        }

        public MotorServisi(IDepoServisi depoServisi)
        {
            this.depoServisi = depoServisi;
        }

        public bool MotorCalisiyorMu(Araba araba)
        {
            return araba.MotorDurumu;
        }

        public void MotorCalistir(Araba araba)
        {
            if (depoServisi.DepoBosMu(araba))
                throw new BenzinYokException("Arabada Yakıt Yok");

            if (MotorCalisiyorMu(araba))
                throw new MotorZatenCalisiyorException("Motor Zaten Çalışıyor");

            araba.MotorDurumu = true;//Motor Çalıştır;
        }

        public void MotorDurdur(Araba araba)
        {
            if (!MotorCalisiyorMu(araba))
                throw new MotorZatenCalismiyorException("Motor zaten çalışmıyor");
            araba.MotorDurumu = false;//Motor Durdur
        }
    }
}
