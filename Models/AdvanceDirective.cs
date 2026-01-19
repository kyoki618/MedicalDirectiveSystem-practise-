namespace MedicalDirectiveSystem.Models
{
    public class AdvanceDirective
    {
        public string Id { get; set; }               // 改成 string
        public string PatientId { get; set; }        // 對應 Patient 的 Id
        public bool AgreeCPR { get; set; }           // 是否同意急救
        public bool AgreeIntubation { get; set; }    // 是否同意插管
        public string Status { get; set; }           // 草稿/已送出/已確認/作廢
        public DateTime CreatedAt { get; set; }      // 建立時間
    }
}

// Compare this snippet from Models/Physician.cs:
// namespace MedicalDirectiveSystem.Models
