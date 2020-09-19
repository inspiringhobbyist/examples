using System;
namespace examples {
    class tutorial
    {
         int tutorialid;
         string tutorialname;

         public void  setutorial(int pid, string name) {

             tutorialid = pid;
             tutorialname = name;
         }

         public string gettutorial(){

             return tutorialname;
         }

    }


}

