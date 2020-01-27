using System;

namespace Xylyic_Xenon.Services {

    public static class WordFormattingService{

        public static string ChangeFirstLetterToCap(string _orgin){
             var ret = _orgin[0].ToString().ToUpper() + _orgin.Substring(1);
             return ret;
            
        }
    }
}