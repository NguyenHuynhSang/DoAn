using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnSapXep
{
    public class Node
    {
        private int giatri;

        public int Giatri
        {
            get
            {
                return giatri;
            }

            set
            {
                if (value>ThamSo.GiaTriLonNhat)
                {
                    return;
                }
                giatri = value;
            }
        }

        public int Vitri
        {
            get
            {
                return vitri;
            }

            set
            {
                vitri = value;
            }
        }

        private int vitri;
        public enum LoaiDiChuyen
        {
            DiLen_Dixuong,QuaPhai_QuaTrai,DiXuong_DiLen,DungYen     
        }
    }
}
