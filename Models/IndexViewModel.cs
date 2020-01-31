using System;

namespace Xylyic_Xenon.Models {
    public class IndexViewModel{
        public string projName {get; set;}
        public BackgroundModel background {get; set;}

        public IndexViewModel(string _projName, BackgroundModel backgroundModel){
            projName = "Project " + _projName;
            background = backgroundModel;
        }


    }
}