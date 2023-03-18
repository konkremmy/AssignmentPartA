using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{
    class TrainerServices
    {
        private MyDataBase db = new MyDataBase();

        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }

        public void CreateTrainer(Trainer trainer)
        {
            int lastId = db.Trainers[db.Trainers.Count - 1].TrainerId;
            trainer.TrainerId = lastId + 1;
            db.Trainers.Add(trainer);
        }
    }
}
