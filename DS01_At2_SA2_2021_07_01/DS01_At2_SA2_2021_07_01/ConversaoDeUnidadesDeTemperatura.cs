using System;
using System.Collections.Generic;
using System.Text;

namespace DS01_At2_SA2_2021_07_01
{
    class ConversaoDeUnidadesDeTemperatura
    {
        public static float CelsiusParaKelvin(float c)
        {
            //K = C + 273.15 
            return c + 273.15f;
        }
        public static float CelsiusParaFahrenheit(float c)
        {
            //F = (9 × C/5) + 32) 
            return (9f * c / 5) + 32;
        }

        public static float FahrenheitParaCelsius(float f)
        {
            //C = (F − 32) × +5/9 
            return (f - 32f) * (5f / 9f);
        }
        public static float FahrenheitParaKelvin(float f)
        {
            return CelsiusParaKelvin(FahrenheitParaCelsius(f));
        }
        public static float KelvinParaCelsius(float k)
        {
            //C = K − 273.15 
            return k - 273.15f;
        }
        public static float KelvinParaFahrenheit(float k)
        {
            return CelsiusParaFahrenheit(KelvinParaCelsius(k));
        }

        public int xyz()
        {
            return 0;
        }

    }
}
