namespace Ice_task_3_y2_semester_1
{
    public partial class Form1 : Form
    {
        private List<Item> UserCart = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list
            // Determine the price based on the selected item
            // Get the quantity of the selected item
            // Create a new Item object and add it to the UserCart list
            if (lstItems.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to order");
                lstItems.Focus();
                return;
            }

            Items selectedItem = (Items)lstItems.SelectedItem;
            double price = 0;
            switch (selectedItem)
            {
                case Items.Tea:
                    price = 12;
                    break;
                case Items.Springroll:
                    price = 7;
                    break;
                case Items.Samoosa:
                    price = 5;
                    break;
                case Items.Coffee:
                    price = 22;
                    break;
                case Items.Chips:
                    price = 10;
                    break;
            }
            int Quantity = (int)UDQuantity.Value;

            if (Quantity <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than 0");
                UDQuantity.Focus();
                return;
            }

            Item item = new Item(selectedItem, price, Quantity);
            MessageBox.Show($"Item successfully added: {item.ItemName} R{item.Price} Quantity: {item.Quantity}");
            UserCart.Add(item);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Calculate the total price of all items in the cart
            // Generate a display receipt with item details and total price
            // Display the receipt in a message box
            double TotalPrice = 0;
            string displayreceipt = "";
            foreach (Item item in UserCart)
            {
                TotalPrice += item.Price;
                displayreceipt += $"Product name: {item.ItemName} - x{item.Quantity}\n 1 item R {item.Price}, {item.Quantity} item(s) R {item.Quantity * item.Price}  \n\n";
            }
            displayreceipt += $"Total price: {TotalPrice}";
            if (UserCart.Count == 0)
            {
                MessageBox.Show("There are no items to display");
            }
            else
            {
                MessageBox.Show(displayreceipt);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
