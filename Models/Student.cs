using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KuliahkuApp.Models
{
    public enum Gender
    {
        [Description("Laki-laki")]
        LakiLaki,
        [Description("Perempuan")]
        Perempuan
    }

    public class Student
    {
        [Key]
        public string Nim { get; set; }
        [DisplayName("Nama Mahasiswa")]

        public string Nama_Mhs { get; set; }
        [DisplayName("Tanggal Lahir")]
        public DateTime Tgl_Lahir { get; set; }
        public string Alamat { get; set; }
        [DisplayName("Jenis Kelamin")]

        public Gender JenisKelamin { get; set; }
        public Student()
        {

        }
    }
}
