using System.Collections.Generic;

public static class BankPertanyaan
{
    public static List<Pertanyaan> Buat()
    {
        return new List<Pertanyaan>
        {
            new Pertanyaan("Athena adalah kota pertama yang menerapkan sistem demokrasi.", true,
                "FAKTA. Reformasi Kleisthenes sekitar tahun 508 SM sering dianggap sebagai awal demokrasi Athena."),

            new Pertanyaan("Semua warga Athena boleh ikut memilih dalam demokrasi.", false,
                "MITOS. Perempuan, budak, dan orang asing tidak punya hak suara. Hanya laki-laki dewasa yang berstatus warga."),

            new Pertanyaan("Olimpiade kuno pertama kali diadakan di Olympia.", true,
                "FAKTA. Olimpiade kuno diadakan di Olympia untuk menghormati Zeus, dan tercatat dimulai pada 776 SM."),

            new Pertanyaan("Pasukan Sparta berjumlah 300 orang saja saat melawan Persia di Thermopylae.", false,
                "MITOS. Leonidas memimpin 300 prajurit Sparta, tetapi didukung ribuan pasukan dari kota-kota Yunani lain."),

            new Pertanyaan("Kuda Troya benar-benar ada, ditemukan para arkeolog di Turki.", false,
                "MITOS. Kisah Kuda Troya hanya ada dalam tradisi sastra. Belum ada bukti arkeologis bahwa kuda kayu itu pernah ada."),

            new Pertanyaan("Alexander Agung berguru kepada Aristoteles saat masih muda.", true,
                "FAKTA. Raja Philip II dari Makedonia mengundang Aristoteles untuk menjadi guru Alexander."),

            new Pertanyaan("Patung dan kuil Yunani kuno aslinya berwarna putih polos.", false,
                "MITOS. Aslinya dicat dengan warna-warna cerah. Catnya hilang dimakan waktu."),

            new Pertanyaan("Sparta dan Athena pernah berperang dalam Perang Peloponnesos.", true,
                "FAKTA. Perang ini berlangsung 431-404 SM dan berakhir dengan kemenangan Sparta."),

            new Pertanyaan("Socrates menulis sendiri semua ajaran filsafatnya dalam buku.", false,
                "MITOS. Socrates tidak meninggalkan tulisan. Ajarannya diketahui lewat murid-muridnya, terutama Plato."),

            new Pertanyaan("Yunani kuno bersatu sebagai satu negara di bawah satu pemerintahan.", false,
                "MITOS. Yunani kuno terdiri dari banyak kota-negara (polis) merdeka seperti Athena, Sparta, dan Korintus."),

            new Pertanyaan("Hippokrates dikenal sebagai Bapak Kedokteran.", true,
                "FAKTA. Hippokrates mendorong ilmu kedokteran yang berdasar pengamatan, bukan sekadar takhayul."),

            new Pertanyaan("Pemenang Olimpiade kuno diberi medali emas.", false,
                "MITOS. Pemenang menerima mahkota dari ranting zaitun, bukan medali emas."),
        };
    }
}