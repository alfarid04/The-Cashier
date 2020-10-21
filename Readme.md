# The Cashier
Aplikasi ini mencakup fungsi perhitungan yaitu penjumlahan dan perkalian yang digunakan untuk menghitung jumlah barang/jasa yang akan dibeli oleh pembeli atau pelanggan

# Scope & Functionalities
~user dapat mengetikan/memasukkan kata(huruf/angka)

~user dapat memilih barang/jasa yang akan dibeli

~user dapat menyentuh tombol Tambahkan

~user dapat melihat data list yang telah ditambahkan sebelumnya
# How Does it Works?
Diawali dengan method MainWindow pada class MainWindow.xaml.cs, kita mendeklarasikan
```csharp
 public MainWindow()
        {
            InitializeComponent();
            Calculator = new Calculator();
            Listbox.ItemsSource = Calculator.getListItem();
        }
```
logika perhitungan terdapat pada class Item.cs Cara kerjanya yaitu menjumlahkan semua price dengan quantitynya.
```csharp
public double getSubtotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
```
# Terima Kasih