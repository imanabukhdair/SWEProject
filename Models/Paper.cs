﻿/*
                  PAPER CLASS
    holds all information for the Paper table in the
    database. All the variables should correspong to 
    each of the columns/elements of the Paper table.
 
 */

using System;
using System.Collections.Generic; //Taken from this tutorial https://www.youtube.com/watch?v=rTXozMmFVqA
using System.Linq;                //Also taken from this tutorial ^
using System.Threading.Tasks;     //This one too

namespace CPMS.Models
{
    public class Paper
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PaperID { get; set; }
        public string? AuthorID { get; set; }
        public string? Title { get; set; }
        public DateOnly? DatePublished { get; set; }
        public int? Pages { get; set; }
        public string? FileName { get; set; }
        public string? NotesToReviewers { get; set; }

        // ALL THE DIFFERENT PAPER TOPICS A REVIEWER MAY REVIEW
        public bool? AnalysisOfAlgorithms { get; set; }
        public bool? Applications { get; set; }
        public bool? Architecture { get; set; }
        public bool? ArtificialIntelligence { get; set; }
        public bool? ComputerEngineering { get; set; }
        public bool? Curriculum { get; set; }
        public bool? DataStructures { get; set; }
        public bool? Databases { get; set; }
        public bool? DistanceLearning { get; set; }
        public bool? DistributedSystems { get; set; }
        public bool? EthicalSocialIssues { get; set; }
        public bool? FirstYearComputing { get; set; }
        public bool? GenderIssues { get; set; }
        public bool? GrantWriting { get; set; }
        public bool? GraphicsImageProcessing { get; set; }
        public bool? HumanComputerInteraction { get; set; }
        public bool? LaboratoryEnvironments { get; set; }
        public bool? Literacy { get; set; }
        public bool? MathematicsInComputing { get; set; }
        public bool? Multimedia { get; set; }
        public bool? NetworkingDataCommunications { get; set; }
        public bool? NonmajorCourses { get; set; }
        public bool? ObjectOrientedIssues { get; set; }
        public bool? OperatingSystems { get; set; }
        public bool? ParallelProcessing { get; set; }
        public bool? Pedagogy { get; set; }
        public bool? ProgrammingLanguages { get; set; }
        public bool? Research { get; set; }
        public bool? Security { get; set; }
        public bool? SoftwareEngineering { get; set; }
        public bool? SystemsAnalysisAndDesign { get; set; }
        public bool? UsingTechnologyInTheClassroom { get; set; }
        public bool? WebAndInternetProgramming { get; set; }
        public bool? Other { get; set; }


    }//end public class Paper
}//end namespace CPMS.Models

