
double quiz1, quiz2, quiz3, quizGrade;
double recitation;
double lab1, lab2;
double classStanding;
double majorExam;

quiz1 = 86.15;
quiz2 = 87.00;
quiz3 = 75.29;

recitation = 78.00;

lab1 = 92.14;
lab2 = 87.15;

majorExam = 87.65;

quizGrade = (quiz1 + quiz2 + quiz3) / 3*0.25;
recitation = recitation * 0.1;
lab1 = lab1 * 0.1;
lab2 = lab2 * 0.1;
majorExam = majorExam * 0.35;

classStanding = quizGrade + recitation + lab1 + lab2 + majorExam;

Console.WriteLine("The semestral grade is: " + classStanding);


