using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartA
{
    class AssignmentServices
    {
        private MyDataBase db = new MyDataBase();

        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }

        public void CreateAssignment(Assignment assignment)
        {
            int lastId = db.Assignments[db.Assignments.Count - 1].AssignmentId;
            assignment.AssignmentId = lastId + 1;
            db.Assignments.Add(assignment);
        }
    }
}
