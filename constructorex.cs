using System;
namespace examples {


    class employee {

        int employeeid;
        string employeename;


        public  employee() {            // here employee is constructor (to be same name as class) initializing properties of class employee
                                        // inshort it gives default values to properties of this class whenever there is instance created    
             
             employeeid = 0;
             employeename = "default";

        }

        public void setemployeedetails(int IDpara, string Empname) {

             employeeid = IDpara;
             employeename = Empname;

        }
        public string getemployeename() {

                 
                 return employeename;

        }


    }


}
