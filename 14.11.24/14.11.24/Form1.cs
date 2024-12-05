namespace _14._11._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWishList();
        }

        private void InitializeWishList()
        {
            ListView listView1 = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView1.Columns.Add("", 40);
            listView1.Columns.Add("", 5);
            listView1.Columns.Add("Item", 150);
            listView1.Columns.Add("Price", 100);

            string[] items = { "House", "Keyboard"};
            int[] prices = { 122000, 60};
            ImageList imageList = new ImageList();

            imageList.Images.Add(Bitmap.FromFile("house.png"));
            imageList.Images.Add(Bitmap.FromFile("keyboard.png"));

            listView1.SmallImageList = imageList;

            for (int i = 0; i < items.Length; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Add("");
                listItem.SubItems.Add(items[i]);
                listItem.SubItems.Add(prices[i].ToString() + " USD");
                listItem.ImageIndex = i;

                listView1.Items.Add(listItem);
            }
            this.Controls.Add(listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}