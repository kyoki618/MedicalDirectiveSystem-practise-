namespace MedicalDirectiveSystem.Models
{
    public class Patient
    {
        public string Id { get; set; }
        public string MedicalRecordNo { get; set; } // 病歷號
        public string Name { get; set; }             // 姓名
        public string IdNumber { get; set; }         // 身分證字號
        public DateTime BirthDate { get; set; }      // 出生日期
    }
}

