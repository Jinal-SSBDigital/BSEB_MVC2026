namespace BSEB_MVC.Models
{


    public class Subjects
    {
        public int subjectid { get; set; }

        public string subjectname { get; set; }
        public string subjectcode { get; set; }

        public bool isactive {  get; set; }
        public bool isactivelocked { get; set; }

        public List<Compulsarygrp1> Compulsarygrp1 { get; set; }
        public List<Compulsarygrp2> Compulsarygrp2 { get; set; }
        public List<Eleactivegrp> Eleactivegrp { get; set; }
        public List<Additionalgrp> Additionalgrp { get; set; }
    }
    public class Compulsarygrp1
    {
            public int subjectid { get; set; }

            public string subjectname { get; set; }
            public string subjectcode { get; set; }

            public bool isactive { get; set; }
            public bool isactivelocked { get; set; }
    }
    public class PreviousSubject
    {
            public int subjectid { get; set; }

            public string subjectname { get; set; }
            public string subjectcode { get; set; }

            public bool isactive { get; set; }
            public bool isactivelocked { get; set; }
    }
    public class Compulsarygrp2
    {
                public int subjectid { get; set; }

                public string subjectname { get; set; }
                public string subjectcode { get; set; }

                public bool isactive { get; set; }
                public bool isactivelocked { get; set; }
    }
    //public class Eleactivegrp
    //{
    //            public int subjectid { get; set; }

    //            public string subjectname { get; set; }
    //            public string subjectcode { get; set; }

    //            public bool isactive { get; set; }
    //            public bool isactivelocked { get; set; }
    //}
    public class Additionalgrp
    {
                public int subjectid { get; set; }

                public string subjectname { get; set; }
                public string subjectcode { get; set; }

                public bool isactive { get; set; }
                public bool isactivelocked { get; set; }
    }


}
