using System;
using View;
using Controller;
using DB;
using SD;
using HUM;
using EntityFWextensions;
using ExtensionMS;
using UT;

namespace Development
{
    // API
    public class ApplicationalProgram
    {   
        // Main Routine to call Methods from other Classes in The Namespace Nomenclature
        // ===========
        // Separation of Concerns
        // SOLID - Single Responsibility Principle
        // -----------
        // 'Polymorph': InterfaceRoutines InstantiateViewUnitTesting =
        //              new InterfaceRoutines();
        //  InstantiateView.Display();
        static void Main()
        {
            // Main Menu Screen Output
            ViewRoutines _instantiateView = new ViewRoutines();
            _instantiateView.MenuInterface(0);

            // Unit Testing - Structural Integrity
            //   bool UTresult = StructuralIntegrityUTintegration(); Console.WriteLine(UTresult);
        }
        // Structural Integrity Test Complete as Solid
        static bool StructuralIntegrityUTintegration(){
           // Instantiations
           ViewRoutines _instantiateViewUT1 =
            new ViewRoutines();
           _instantiateViewUT1.Display();
           ControllerRoutines _instantiateViewUT2 =
            new ControllerRoutines();
           _instantiateViewUT2.Display();
           DBroutines _instantiateViewUT3 =
            new DBroutines();
           _instantiateViewUT3.Display();
           SDroutines _instantiateViewUT4 =
            new SDroutines();
           _instantiateViewUT4.Display();
           HUMroutines _instantiateViewUT5 =
            new HUMroutines();
           _instantiateViewUT5.Display();
           EntityRoutines _instantiateViewUT6 =
            new EntityRoutines();
           _instantiateViewUT6.Display();
           ExtensionMSroutines _instantiateViewUT7 =
            new ExtensionMSroutines();
           _instantiateViewUT7.Display();
           UTroutines _instantiateViewUT8 =
            new UTroutines();
           _instantiateViewUT8.Display();
           return true;
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project0 - Feb 12, 2021 Received Original Specifications
//           - Feb 18, 2021 Received Requested Specifications
//           - Feb 24, 2021 Requested Deliverable
//
//  Project Lead - Revature Corporate Trainor Nick Escalon
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight