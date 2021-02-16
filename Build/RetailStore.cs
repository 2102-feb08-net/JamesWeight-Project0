using System;
using View;
using Controller;

namespace Application
{
    class Program
    {       
        static void Main()
        {
            InterfaceRoutines InstantiationView = new InterfaceRoutines();
            ControllerRoutines InstantiationController = new ControllerRoutines();

            InstantiationView.Display();
            InstantiationController.TestDisplay();
        }
    }
}

// Revature:
//  Batch - 2021F2102-feb08-net
//   Project0 - Feb 12, 2021 Received Specifications
//            - Feb 24, 2021 Requested Deliverable
//  Project Lead - Nick Escalon
//          Deliverable Author - James Weight