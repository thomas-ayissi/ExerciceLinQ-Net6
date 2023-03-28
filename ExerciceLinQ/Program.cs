using LinQ_DataContext;

DataContext dc = new DataContext();

/*2.1*/
/*Ecrire une requête pour présenter, pour chaque étudiant, le nom de l’étudiant, la
date de naissance, le login et le résultat pour l’année de l’ensemble des étudiants.*/

/*var result_2_1 = dc.Students.Select(s => new { 
                                        Nom = s.Last_Name,
                                        DateNaissance = s.BirthDate,
                                        s.Login,
                                        Resultat = s.Year_Result });

var result_2_1 = from Student s in dc.Students
                 select new
                 {
                     Nom = s.Last_Name,
                     DateNaissance = s.BirthDate,
                     s.Login,
                     Resultat = s.Year_Result
                 };

foreach (var item in result_2_1)
{
    Console.WriteLine($"{item.Nom} {item.DateNaissance} {item.Login} {item.Resultat}");
}
*/
/*2.2*/
/*Ecrire une requête pour présenter, pour chaque étudiant, son nom complet (nom
et prénom séparés par un espace), son id et sa date de naissance.*/

/*var result_2_2 = from Student s in dc.Students
                 select new
                 {
                     NomComplet = s.Last_Name + " " + s.First_Name,
                     Id = s.Student_ID,
                     DateNaissance = s.BirthDate
                 };

var result_2_2 = dc.Students.Select(s => new {
                                            NomComplet = s.Last_Name + " " + s.First_Name,
                                            Id = s.Student_ID,
                                            DateNaissance = s.BirthDate
                                        });

foreach (var item in result_2_2)
{
    Console.WriteLine($"{item.NomComplet} {item.DateNaissance} {item.Id}");
}*/

/*2.3*/
/*Ecrire une requête pour présenter, pour chaque étudiant, dans une seule chaine de
caractère l’ensemble des données relatives à un étudiant séparées par le symbole |.*/

/*IEnumerable<string> result_2_3 = dc.Students.Select(s => string.Join(" | ", s.Student_ID, s.Last_Name, s.First_Name, s.BirthDate, s.Login, s.Year_Result, s.Section_ID, s.Course_ID));

IEnumerable<string> result_2_3 = from Student s in dc.Students
                                 select string.Join(" | ", s.Student_ID, s.Last_Name, s.First_Name, s.BirthDate, s.Login, s.Year_Result, s.Section_ID, s.Course_ID);

foreach (string item in result_2_3)
{
    Console.WriteLine(item);
}*/