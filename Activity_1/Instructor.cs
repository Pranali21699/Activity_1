using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    public class Instructor
    {      //Fields
        public float avgFeedback;
        public int experience;
        public string instructorName;
        public string[] instructorSkill;


        //Methods

        public bool CheckSkill(string technology) {
            bool flag = false;
            foreach (string i in instructorSkill)
            {
                if (i == technology)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;

        }

            

        /* public Instructor()
        { }*/

         public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill) {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;

            if (avgFeedback < 1.0 || avgFeedback > 5.0)
            {
                throw (new FormatException("Average Feedback should be greater than 1.0 and less than 5.0"));
            }

            if (experience < 2)
            {
                throw (new FormatException("Atleast 2 years experience required."));
            }

            if (instructorName == null)
            {
                throw (new ArgumentNullException("Instructor name should be entered"));
            }
        }

        public bool ValidateEligibility() {
            bool flag = false;

            if (experience > 3&& avgFeedback >= 4.5)
            {
                flag = true;
                     return flag;
            }

           else if (experience <= 3 && avgFeedback >= 4)
            {
                flag = true;

                return flag ; 
            }
           else 
                return flag;
            
        
        }




    }
}
