using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QAwebApp.Models
{
    public class FormModel
    {
        //Unit details
        //-------------------
        public int Id { get; set; }
        public string Division { get; set; }
        public string Bul1 { get; set; }
        public string Bul2 { get; set; }
        public string Bul3 { get; set; }
        public string Country { get; set; }

        public string AssessmentPeriod { get; set; }
        public string UnitAssessor { get; set; }
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfAssessment { get; set; }


        //Grading criteria
        //--------------------

        //Group Risk comment to scoring
        public string BCMGrComment { get; set; }
        public string IRHGrComment { get; set; }
        public string NPAPGrComment { get; set; }
        public string ORSARTSAGrComment { get; set; }
        public string KRIGrComment { get; set; }
        public string ICCGrComment { get; set; }

        public string SummaryGrComment { get; set; }



        //Unit comment to score
        public string BCMUnitComment { get; set; }
        public string IRHUnitComment { get; set; }
        public string NPAPUnitComment { get; set; }
        public string ORSARTSAUnitComment { get; set; }
        public string KRIUnitComment { get; set; }
        public string ICCUnitComment { get; set; }
        public string SummaryUnitComment { get; set; }

        //score
        public int BCMScore { get; set; }
        public int IRHScore { get; set; }
        public string NPAPScore { get; set; }
        public string ORSARTSAScore { get; set; }
        public int KRIScore { get; set; }
        public int ICCScore { get; set; }


        public int TotalScore { get { return Total(BCMScore, IRHScore, NPAPScore, ORSARTSAScore, KRIScore, ICCScore); } }

        public int Total(int bcm, int irh, string npap, string orsartsa, int kri, int icc)
        {
            int total = 0;
            int npapInt;
            int orsartsaInt;
            bool npapValid = Int32.TryParse(npap, out npapInt);
            bool orsartsaValid = Int32.TryParse(orsartsa, out orsartsaInt);

            if (npapValid && orsartsaValid)
            {
                total = bcm + irh + npapInt + orsartsaInt + kri + icc;
            }

            if (npapValid && !orsartsaValid)
            {
                total = bcm + irh + npapInt + kri + icc;
            }

            if (!npapValid && orsartsaValid)
            {
                total = bcm + irh + orsartsaInt + kri + icc;
            }

            if (!npapValid && !orsartsaValid)
            {
                total = bcm + irh + kri + icc;
            }

            return total;
        }

        //Unit responsible
        //public UnitResponsibleModel UnitResponsible { get; set; }
        public int? UnitResponsibleId { get; set; }

        public UnitResponsibleModel UnitResponsible { get; set; }

        public string ManagerSid { get; set; }
        public UserModel User { get; set; }

        public string EmailSent { get; set; }

        public string Creator { get; set; }
    }
}
