namespace BookMan.Framework
{
    /// <summary>
    /// Mot so phuong thuc mo rong de bien doi kieu du lieu
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Bien doi tu chuoi sang so nguyen
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static  int ToInt(string value){
            return int.Parse(value);
        }

        /// <summary>
        /// Bien doi tu chuoi sang so nguyen
        /// </summary>
        /// <param name="value"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool ToInt(this string value, out int i){
            return int.TryParse(value, out i);
        }

        /// <summary>
        /// chuyen chuoi Y,y,true, TRUE sang true
        /// cac chuoi con lai nhan gia tri false 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBool (string value){
            var v = value.ToLower();
            if(v=="y"||v=="true")
                return true;
            return false;
        }

        public static string ToString(this bool value, string format){
            if(format == "y/n")
                return value ? "Yes" : "No";
            
            if(format =="c/k")
                return value? "Co": "Khong";

            return value? "true" : "false";
        }
    }
}