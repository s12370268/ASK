using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASK.AspNetCore.School.Web.Models
{
    public class Course
    {
        /// <summary>
        /// 課程編號
        /// </summary>
        [DisplayName("課程編號")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="課程編號沒填寫")]
        public int ID { get; set; }
        /// <summary>
        /// 課程名稱
        /// </summary>
        [DisplayName("課程名稱")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        /// <summary>
        /// 學分數
        /// </summary>
        [DisplayName("學分數")]
        [DataType(DataType.Text)]
        public int Credit { get; set; }
    }
}
