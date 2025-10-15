using CodeChallenge.PartLengthCalculation.Answers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.PartLengthCalculation.CodeChallenge
{
    public static class PartLengthCalculator
    {
        /// <summary>
        /// This method will use the part callout information to calculate the part length in inches.  Close attention should be
        /// paid to the callout options for accurate length calculations
        /// </summary>
        /// <param name="part">The part object we will be evaluating for length</param>
        /// <returns>The final calculated part length from this method that will be compared to the Samtec calculation</returns>
        public static float DeterminePartLength(Part part)
        {
            float partLength = 0.0f;
            int divisor = part.HasOption("-DP") ? 16 : 26;
            var validPositions = part.HasOption("-DP")
                ? new[] { 16, 32, 48 }
                : new[] { 26, 52, 78, 104 };

            // Validar divisibilidad
            if (part.NumberOfPositions % divisor != 0)
                throw new ArgumentException($"El número de posiciones ({part.NumberOfPositions}) no es divisible entre {divisor} para la configuración {(part.HasOption("-DP") ? "con -DP" : "sin -DP")}. Callout: {part.Callout}");

            int banks = Math.Max(1, part.NumberOfPositions / divisor);

            // Longitud base
            partLength = ((banks * .840f) - .020f);

            // GP: +0.51
            if (part.HasOption("-GP"))
                partLength += 0.51f;

            // PX4 (PC4/PT4): +0.54
            else if ((part.HasOption("-PC4") || part.HasOption("-PT4"))
                && !part.HasOption("-A")
                && !part.HasOption("-GP")
                && !part.HasOption("-K")
                && validPositions.Contains(part.NumberOfPositions))
            {
                partLength += 0.54f;
            }

            // PX8 (PC8/PT8): +0.855
            else if ((part.HasOption("-PC8") || part.HasOption("-PT8"))
                && !part.HasOption("-A")
                && !part.HasOption("-GP")
                && !part.HasOption("-K")
                && validPositions.Contains(part.NumberOfPositions))
            {
                partLength += 0.855f;
            }

            // RF1: +0.605
            else if (part.HasOption("-RF1")
                && !part.HasOption("-A")
                && !part.HasOption("-GP")
                && validPositions.Contains(part.NumberOfPositions))
            {
                partLength += 0.605f;
            }

            // RF2: +1.105
            else if (part.HasOption("-RF2")
                && !part.HasOption("-A")
                && !part.HasOption("-GP")
                && validPositions.Contains(part.NumberOfPositions))
            {
                partLength += 1.105f;
            }

            // RT1: +0.605
            else if (part.HasOption("-RT1")
                && !part.HasOption("-GP")
                && !part.HasOption("-PC4")
                && !part.HasOption("-PC8")
                && !part.HasOption("-RF1")
                && !part.HasOption("-RF2")
                && validPositions.Contains(part.NumberOfPositions))
            {
                partLength += 0.605f;
            }
            else if (part.HasOption("-RT1")
            && part.HasOption("-DP")
            && !part.HasOption("-GP")
            && !part.HasOption("-PC4")
            && !part.HasOption("-PC8")
            && !part.HasOption("-RF1")
            && !part.HasOption("-RF2")
            && (validPositions.Contains(part.NumberOfPositions) || part.NumberOfPositions==64))
            {
                partLength += 0.605f;
            }

            // -DP does not affect length
            return partLength;
        }
    }
}