using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Exam.Bingo;

namespace BLL_Exam.Bingo
{
    public class cls_Juego_BLL
    {
        public void GenerarResultadoPartida(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            Obj_Bingo_DAL.ranNumeros = new Random();

            switch (Obj_Bingo_DAL.bOpcJuego)
            {
                case 1:
                    {
                        // JUEGO CARTÓN EN 4 ESQUINAS
                        Juego_IV_Esquinas(ref Obj_Bingo_DAL);
                        break;
                    }
                case 2:
                    {
                        // JUEGO CARTÓN EN "T"
                        Juego_T(ref Obj_Bingo_DAL);
                        break;
                    }
                case 3:
                    {
                        // JUEGO CARTÓN EN "X"
                        Juego_X(ref Obj_Bingo_DAL);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Juego_IV_Esquinas(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {
                Obj_Bingo_DAL.arrCartonCompleto = new byte[24];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                    }

                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }

        }

        // Metodo llena arreglo con numeros no repetidos y selecciona numeros impares no repetidos para formar la T
        private void Juego_X(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {
                Obj_Bingo_DAL.arrCartonCompleto = new byte[24];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        if (i == 0 || i == 4 || i == 6 || i == 8 || i == 15 || i == 17 || i == 19 || i == 23)
                        {
                            if (Obj_Bingo_DAL.bNumBolita % 2 != 0)
                            {
                                Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }
        }

        // Metodo llena arreglo con numeros no repetidos y selecciona numeros pares no repetidos para formar la T
        private void Juego_T(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {
                Obj_Bingo_DAL.arrCartonCompleto = new byte[24];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 7 || i == 16 || i == 21)
                        {
                            if (Obj_Bingo_DAL.bNumBolita % 2 == 0)
                            {
                                Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}

