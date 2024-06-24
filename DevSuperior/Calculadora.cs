using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperior {
    internal class Calculadora {

       public static int Soma(params int[] nums) {
            int resultado = 0;

            for(int i = 0; i < nums.Length; i++) {
                resultado += nums[i];
            }

            return resultado;
        }                     
        

    }
}