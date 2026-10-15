using System;
class item
{
    public string Judul;
    public int Tahun;

    public item(string judul, int tahun)
    {
        Judul = judul;
        Tahun = tahun;
    }
    public virtual string deskripsi()
    {
        return $"Judul {Judul}, Tahun {Tahun}";
    }
    public void InfoItem()
    {
        Console.WriteLine(deskripsi());
    }
}

class buku : item
{
    public string Penulis;
    public buku(string judul, int tahun, string penulis) : base(judul, tahun)
    {
        Penulis = penulis;
    }
    public void InfoPenulis()
    {
        Console.WriteLine($"Penulis: {Penulis}");
    }
    public override string deskripsi()
    {
        return $"buku : {Judul}, Tahun: {Tahun}, Penulis: {Penulis}";
    }
}

class majalah : item
{
    public string Edisi;
    public majalah(string judul, int tahun, string edisi) : base(judul, tahun)
    {
        Edisi = edisi;
    }
    public void InfoEdisi()
    {
        Console.WriteLine($"Edisi: {Edisi}");
    }
    public override string deskripsi()
    {
        return $"Majalah : {Judul}, Tahun: {Tahun}, Edisi {Edisi}";
    }
}

class novel : buku
{
    public novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }
    public void BacaSinopsis()
    {
        Console.WriteLine($"Sinopsis Novel : {Judul} : Mengisahkan Kekejaman rezim orde baru serta perjuangan para aktivis mahasiswa menjelang peristiwa reformasi 1998 ");
    }
    public override string deskripsi()
    {
        return $"Novel : {Judul}, Tahun : {Tahun}, Penulis : {Penulis}";
    }
}

class komik : buku
{
    public komik(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }
    public void TampilkanIlustrasi()
    {
        Console.WriteLine($"Ilustrasi KOmik : {Judul} : Sosok pemuda berambut jabrik, bermata bulat melotot dan brgigi tonggos yang mengaku dirinya anti-mainstream serta sangat populer ");
    }
    public override string deskripsi()
    {
        return $"Komik : {Judul}, Tahun : {Tahun}, Penulis {Penulis}";
    }
}

class MajalahAnak : majalah
{
    public MajalahAnak(string judul, int tahun, string edisi) : base(judul, tahun, edisi) { }
    public void KatagoriAnak()
    {
        Console.WriteLine($"Katagori Maajalah Anak: {Judul} : Judul majalah anak yang ingin dibaca");
    }
    public override string deskripsi()
    {
        return $"Majalah Anak : {Judul}, Tahun : {Tahun}, Edisi : {Edisi}";
    }
}

class MajalahTeknology : majalah
{
    public MajalahTeknology(string judul, int tahun, string edisi) : base(judul, tahun, edisi) { }
    public void TopicTeknology()
    {
        Console.WriteLine($"Katagory Majalah Anak: {Judul}, Judul majalah tejnology yang ingin dibaca");
    }
    public override string deskripsi()
    {
        return $"Majalah Teknology: {Judul}, Tahun: {Tahun}, Edisi: {Edisi}";
    }
}

class Perpustakaan
{
    private List<item> koleksi = new List<item>();
    public void TambahItem(item item)
    {
        koleksi.Add(item);
    }
    public void DaftarItem()
    {
        foreach (item item in koleksi)
        {
            Console.WriteLine(item.deskripsi());
        }
    }
}

class Program
{
    static void Main()
    {
        Perpustakaan perpustakaan = new Perpustakaan();

        novel novel = new novel(
            "Laut Bercerita", 2017, "Leila.S"
        );
        majalah majalah = new majalah(
            "The National Grapich", 1888, "Bulanan"
        );
        komik komik = new komik(
            "Si Juki", 1969, "Faza Meonk"
        );
        MajalahTeknology majalahteknologi = new MajalahTeknology(
            "Majalah Diktisaintek", 2025, "2026"
        );
        MajalahAnak majalahanak = new MajalahAnak(
            "Bobo Indonesia", 1973, "50 Tahun"
        );

        perpustakaan.TambahItem(novel);
        perpustakaan.TambahItem(majalah);
        perpustakaan.TambahItem(komik);
        perpustakaan.TambahItem(majalahteknologi);
        perpustakaan.TambahItem(majalahanak);

        Console.WriteLine("=== DAFTAR PERPUSTAKAAN ===");
        perpustakaan.DaftarItem();

        Console.WriteLine("\n=== SOAL 1 ===");
        Console.WriteLine(novel.deskripsi());
        Console.WriteLine(majalah.deskripsi());

        Console.WriteLine("\n=== SOAL 2 ===");
        novel.BacaSinopsis();

        Console.WriteLine("\n=== SOAL 3 ===");
        Console.WriteLine($"Judul: {novel.Judul}");
        Console.WriteLine($"Tahun: {novel.Tahun}");
        Console.WriteLine($"Penulis: {novel.Penulis}");

        Console.WriteLine("\n=== SOAL 4 ===");
        majalahteknologi.TopicTeknology();

        Console.WriteLine("\n=== SOAL 5 ===");
        item itemKomik = komik;
        Console.WriteLine(itemKomik.deskripsi());

        Console.WriteLine("\n=== METHOD KHUSUS LAIN ===");
        Console.WriteLine("\n=== METHOD KHUSUS ===");
        komik.TampilkanIlustrasi();
        Console.WriteLine();
        novel.BacaSinopsis();
        Console.WriteLine();
        majalah.InfoEdisi();
        Console.WriteLine();
        majalahanak.KatagoriAnak();
        Console.WriteLine();
        majalahteknologi.TopicTeknology();
    }
}