using System.Collections.Generic;

namespace Garage.Test {
    class CalcUtils {

        public double calcAverageValue (List<double> values) {
            var result = 0.0;
            foreach (double value in values) {
                result += value;
            }

            return result / values.Count;
        }
    }
}