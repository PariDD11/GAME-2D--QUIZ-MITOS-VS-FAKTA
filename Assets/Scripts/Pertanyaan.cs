using System;

[Serializable]
public class Pertanyaan
{
    public string teks;        // pernyataan yang ditampilkan
    public bool isFakta;       // true = FAKTA, false = MITOS
    public string penjelasan;  // penjelasan singkat setelah menjawab

    public Pertanyaan(string teks, bool isFakta, string penjelasan)
    {
        this.teks = teks;
        this.isFakta = isFakta;
        this.penjelasan = penjelasan;
    }
}