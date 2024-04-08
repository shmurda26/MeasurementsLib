using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementsLib
{
    public class MeasurementRepository
    {
        private int _nextId = 30;
        private readonly List<Measurement> _measurements;

        public MeasurementRepository()
        {
            _measurements = new List<Measurement>
            {
            new Measurement { Id = 420, Ppm = 32},
            new Measurement { Id = 2022, Ppm = 69},
            new Measurement { Id = 616, Ppm = 44}
            };
        }
        public List<Measurement> GetAllMeasurements()
        {
            List<Measurement> result = new List<Measurement>(_measurements);


            return result;
        }
        public Measurement? GetById(int id)
        {
            return _measurements.Find(measurement => measurement.Id == id);
        }
        public Measurement AddMeasurement(Measurement measurement)
        {
            measurement.ValidatePpm();
            measurement.Id = _nextId++;
            _measurements.Add(measurement);
            return measurement;
        }

        public Measurement? DeleteMeasurement(int id)
        {
            Measurement? measurement = _measurements.Find(b => b.Id == id);
            if (measurement != null)
            {
                _measurements.Remove(measurement);
            }
            return measurement;
        }

    }
}

