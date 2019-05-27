using System;
using System.Collections.Generic;

namespace Diagnostico_Medico{
    class Diagnostico{
        

        public static void Consulta(){
            String Edad;

            Console.WriteLine("CONSULTA PARA DETECCION DE AGENTES CAUSANTES DE INFECCIONES " + 
                              "\n------------------------------------------------\n");
            Console.WriteLine("¿Qué edad tiene?");
            int EdadR = Convert.ToInt16(Console.ReadLine());

            if(EdadR < 11){
                Edad = "0";
            }else{
                Edad = "1";
            }

            Console.WriteLine("Sí tiene vomito, ¿Con que frecuencia?:\n" +
                              "1) Ocacional\n" +
                              "2) Variable\n" +
                              "3) Frecuente");

            String Vomito = Console.ReadLine();

            Console.WriteLine("Sí tiene fiebre, ¿Con que frecuencia?:\n" +
                              "1) Variable\n" +
                              "2) Poco Frecuente\n" +
                              "3) Frecuente");

            String Fiebre = Console.ReadLine();

            Console.WriteLine("¿Tiene diarrea acuosa?\n" +
                              "1) Si\n" +
                              "2) No");
            
            String Acuosa = Console.ReadLine();

            Console.WriteLine("¿Tiene diarrea con sangre?\n" +
                              "1) Si\n" +
                              "2) No");
            
            String Sangre = Console.ReadLine();

            Console.WriteLine("¿Tiene diarrea mucosa?\n" +
                              "1) Si\n" +
                              "2) No");
            
            String Mucosa = Console.ReadLine();

            diagnostico(Edad + Vomito + Fiebre + Acuosa + Sangre + Mucosa);


        }

        public static void diagnostico(String diago){
            
            switch(diago){
                case "113112":
                    Console.WriteLine("El causante es: Salmonella");
                    informacion(diago);     
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona.");               
                break;

                case "121122":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;

                case "121112":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;

                case "121111":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;
                
                case "121211":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;

                case "121212":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;

                case "121221":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;

                case "121121":
                    Console.WriteLine("El causante es: Campylobacter");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <10 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Animales Domesticos, Fecal-Oral.");
                break;
            
                case "113122":
                    Console.WriteLine("El causante es: Shigella");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 4-7 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111122":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111112":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111111":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111121":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111211":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111212":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "111221":
                    Console.WriteLine("El causante es: Escherichia coli enteroinvasivo");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-5 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "132112":
                    Console.WriteLine("El causante es: Escherichia coli enterohemorrágica");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 7-10 dias (1-10 dias)\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "032112":
                    Console.WriteLine("El causante es: Escherichia coli enterohemorrágica");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 7-10 dias (1-10 dias)\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral.");
                break;

                case "113211":
                    Console.WriteLine("El causante es: Yersinia");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 1-21 dias (Promedio 9 dias)\n" +
                                      "Modo de transmision: Alimentos, Agua, Persona a Persona, Fecal-Oral, Animales Domesticos.");
                break;

                case "131122":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131112":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131111":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131121":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131212":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131221":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "131211":
                    Console.WriteLine("El causante es: Vibrio Cholerae");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: 3-4 dias\n" +
                                      "Modo de transmision: Alimentos, Agua, Fecal-Oral.");
                break;

                case "132111":
                    Console.WriteLine("El causante es: Bacillus cereus y staphylococcus aureus");
                    informacion(diago);
                    Console.WriteLine("Duracion de la Enfermedad: <24 horas\n" +
                                      "Modo de transmision: Alimentos.");

                break;

                default:
                    Console.WriteLine("Consulte a su medico, este sistema no conoce su padecimiento");
                break;

            }

        }


        public static void informacion(String diago){
            Console.WriteLine("Los sintomas que usted padece son los que genera el agente causal");
            if(diago.Substring(0,1).Equals("1") || diago.Substring(0,1).Equals("0")){
                Console.WriteLine("Las personas de su edad pueden contraer ese agente");
            }

            if(diago.Substring(1,1).Equals("1")){
                Console.WriteLine("El vomito ocacional tiende a aparecer cuando se contrae ese agente");
            }else{
                if(diago.Substring(1,1).Equals("2")){
                    Console.WriteLine("El vomito variable tiende a aparecer cuando se contrae ese agente");
                }else{
                    Console.WriteLine("El vomito frecuente tiende a aparecer cuando se contrae ese agente");
                }
            }

            if(diago.Substring(2,1).Equals("1")){
                Console.WriteLine("La fiebre variable tiende a aparecer cuando se contrae ese agente");
            }else{
                if(diago.Substring(1,1).Equals("2")){
                    Console.WriteLine("La fiebre poco frecuente tiende a aparecer cuando se contrae ese agente");
                }else{
                    Console.WriteLine("La fiebre frecuente tiende a aparecer cuando se contrae ese agente");
                }
            }

            if(diago.Substring(3,1).Equals("1")){
                Console.WriteLine("La diarrea acuosa tiende a aparecer cuando se contrae ese agente");
            }else{
                Console.WriteLine("La diarrea acuosa no es un sintoma del agente");
            }

            if(diago.Substring(4,1).Equals("1")){
                Console.WriteLine("La diarrea con sangre tiende a aparecer cuando se contrae ese agente");
            }else{
                Console.WriteLine("La diarrea con sangre no es un sintoma del agente");
            }

            if(diago.Substring(5,1).Equals("1")){
                Console.WriteLine("La diarrea mucosa tiende a aparecer cuando se contrae ese agente");
            }else{
                Console.WriteLine("La diarrea mucosa no es un sintoma del agente");
            }
        }
    }
}