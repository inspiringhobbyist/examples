using System;
namespace examples {
    class tutorial
    {
         int tutorialid;    // property of class  tutorial
         string tutorialname; //property of class tutorial

         public void  setutorial(int pid, string name) {     //method settutorial for class tutorial
              /* three types of access modifiers for methods or property it could be either 
                  public, accessible externally by any program or classs within same namespace
                  private,   not accessible to any external program or class, other than current class 
                  protected, is only accessible by those who inherit this class */ 

             tutorialid = pid;
             tutorialname = name;
         }

         public string gettutorial(){

             return tutorialname;
         }

    }


}

