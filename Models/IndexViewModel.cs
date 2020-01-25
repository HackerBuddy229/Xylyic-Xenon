using System;

namespace Xylyic_Xenon.Models {
    public class IndexViewModel{
        public string projName {get; set;}

        public IndexViewModel(string _projName){
            projName = "Project " + _projName;
        }


    }
}