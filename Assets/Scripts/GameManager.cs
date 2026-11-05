using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI Utama")]
    public TextMeshProUGUI teksPertanyaan;
    public TextMeshProUGUI teksSkor;
    public TextMeshProUGUI teksNyawa;
    public TextMeshProUGUI teksPenjelasan;
    public Button tombolFakta;
    public Button tombolMitos;

    [Header("Game Over (diisi nanti di Langkah 8)")]
    public GameObject panelGameOver;
    public TextMeshProUGUI teksSkorAkhir;

    [Header("Pengaturan")]
    public int nyawaAwal = 3;
    public int poinPerBenar = 10;
    public float jedaPenjelasan = 2.5f;

    private List<Pertanyaan> daftar;
    private int indeks;
    private int skor;
    private int nyawa;
    private bool menungguJawaban;

    void Start()
    {
        MulaiGame();
    }

    public void MulaiGame()
    {
        daftar = BankPertanyaan.Buat();
        Acak(daftar);
        indeks = 0;
        skor = 0;
        nyawa = nyawaAwal;

        if (panelGameOver != null) panelGameOver.SetActive(false);
        teksPenjelasan.text = "";

        UpdateUI();
        TampilkanPertanyaan();
    }

    void TampilkanPertanyaan()
    {
        if (indeks >= daftar.Count)
        {
            GameOver();
            return;
        }

        teksPertanyaan.text = daftar[indeks].teks;
        teksPenjelasan.text = "";
        AturTombol(true);
        menungguJawaban = true;
    }

    // Dipanggil oleh tombol FAKTA
    public void JawabFakta()
    {
        Jawab(true);
    }

    // Dipanggil oleh tombol MITOS
    public void JawabMitos()
    {
        Jawab(false);
    }

    void Jawab(bool jawabanFakta)
    {
        if (!menungguJawaban) return;
        menungguJawaban = false;
        AturTombol(false);

        Pertanyaan p = daftar[indeks];
        bool benar = (p.isFakta == jawabanFakta);

        if (benar)
        {
            skor += poinPerBenar;
            teksPenjelasan.text = "BENAR!\n" + p.penjelasan;
        }
        else
        {
            nyawa--;
            teksPenjelasan.text = "SALAH!\n" + p.penjelasan;
        }

        UpdateUI();
        StartCoroutine(LanjutSetelahJeda());
    }

    IEnumerator LanjutSetelahJeda()
    {
        yield return new WaitForSeconds(jedaPenjelasan);

        indeks++;

        if (nyawa <= 0)
            GameOver();
        else
            TampilkanPertanyaan();
    }

    void GameOver()
    {
        menungguJawaban = false;
        AturTombol(false);

        if (panelGameOver != null)
        {
            panelGameOver.SetActive(true);
            if (teksSkorAkhir != null)
                teksSkorAkhir.text = "Skor Akhir: " + skor;
        }
        else
        {
            teksPertanyaan.text = "GAME OVER\nSkor Akhir: " + skor;
            teksPenjelasan.text = "";
        }
    }

    void UpdateUI()
    {
        teksSkor.text = "Skor: " + skor;
        teksNyawa.text = "Nyawa: " + nyawa;
    }

    void AturTombol(bool aktif)
    {
        tombolFakta.interactable = aktif;
        tombolMitos.interactable = aktif;
    }

    void Acak(List<Pertanyaan> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            Pertanyaan temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}