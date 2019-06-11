using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaEmporuim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GroupBox grp = new GroupBox();
        GroupBox grp2 = new GroupBox();
        RadioButton rdoSmallPizza = new RadioButton();
        RadioButton rdoMediumPizza = new RadioButton();
        RadioButton rdoLargePizza = new RadioButton();
        CheckBox chkCheese = new CheckBox();
        CheckBox chkPepperoni = new CheckBox();
        CheckBox chkSausage = new CheckBox();
        CheckBox chkHamburger = new CheckBox();
        CheckBox chkPineapple = new CheckBox();
        CheckBox chkGreenPeppers = new CheckBox();
        CheckBox chkVeggies = new CheckBox();
        CheckBox chkBlackOlives = new CheckBox();
        RadioButton rdoSmallDrink = new RadioButton();
        RadioButton rdoMediumDrink = new RadioButton();
        RadioButton rdoLargeDrink = new RadioButton();
        RadioButton rdoCoke = new RadioButton();
        RadioButton rdoDietCoke = new RadioButton();
        RadioButton rdoMtDew = new RadioButton();
        RadioButton rdoDietMtDew = new RadioButton();
        RadioButton rdoSprite = new RadioButton();
        RadioButton rdoRootBeer = new RadioButton();
        RadioButton rdoFruitPunch = new RadioButton();
        RadioButton rdoDrPepper = new RadioButton();
        RadioButton rdoWater = new RadioButton();
        ComboBox cboNumberOfServings = new ComboBox();
        RadioButton rdoCaesarSalad = new RadioButton();
        RadioButton rdoCobbSalad = new RadioButton();
        RadioButton rdoChineseSalad = new RadioButton();
        RadioButton rdoSantaFeSalad = new RadioButton();
        RadioButton rdoFour = new RadioButton();
        RadioButton rdoEight = new RadioButton();
        RadioButton rdoTwelve = new RadioButton();
        RadioButton rdoGarlic = new RadioButton();
        RadioButton rdoCinnamon = new RadioButton();
        RadioButton rdoPlain = new RadioButton();
        RadioButton rdoTuesdaySpecial = new RadioButton();
        ComboBox cboTuesdayPizza = new ComboBox();
        RadioButton rdoDinnerSpecial = new RadioButton();
        ComboBox cboDinnerPizza = new ComboBox();
        ComboBox cboDinnerBreadsticks = new ComboBox();
        ComboBox cboDinnerDrink1 = new ComboBox();
        ComboBox cboDinnerDrink2 = new ComboBox();
        RadioButton rdoPartySpecial = new RadioButton();
        ComboBox cboPartyPizza1 = new ComboBox();
        ComboBox cboPartyPizza2 = new ComboBox();
        ComboBox cboPartyPizza3 = new ComboBox();
        ComboBox cboPartyPizza4 = new ComboBox();
        ComboBox cboPartyBreadsticks1 = new ComboBox();
        ComboBox cboPartyBreadsticks2 = new ComboBox();
        ComboBox cboPartyBreadsticks3 = new ComboBox();
        RadioButton rdoShirt1 = new RadioButton();
        RadioButton rdoShirt2 = new RadioButton();
        RadioButton rdoShirt3 = new RadioButton();
        RadioButton rdoShirt4 = new RadioButton();
        PictureBox pbxShirt1 = new PictureBox();
        PictureBox pbxShirt2 = new PictureBox();
        PictureBox pbxShirt3 = new PictureBox();
        PictureBox pbxShirt4 = new PictureBox();
        ComboBox cboShirtSize = new ComboBox();

        List<Product> allOrderItems = new List<Product>();
        


        private void Form1_Load(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.DimGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;
            Clear();
            
            grp.Size = new Size(150,300);
            grp.Location = new Point(10,10);
            grp.Text = "Pizza Size";

            rdoSmallPizza.Text = "Small ($8.00)";
            rdoSmallPizza.Location = new Point(10, 20);
            grp.Controls.Add(rdoSmallPizza);

            rdoMediumPizza.Text = "Medium ($12.00)";
            rdoMediumPizza.Location = new Point(10, 50);
            grp.Controls.Add(rdoMediumPizza);

            rdoLargePizza.Text = "Large ($16.00)";
            rdoLargePizza.Location = new Point(10, 80);
            grp.Controls.Add(rdoLargePizza);
            rdoLargePizza.Checked = true;

            grp2.Size = new Size(150, 300);
            grp2.Location = new Point(170, 10);
            grp2.Text = "Pizza Toppings";

            chkCheese.Text = "4 Cheese";
            chkCheese.Location = new Point(10, 20);
            grp2.Controls.Add(chkCheese);

            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.Location = new Point(10, 50);
            grp2.Controls.Add(chkPepperoni);

            chkSausage.Text = "Sausage";
            chkSausage.Location = new Point(10, 80);
            grp2.Controls.Add(chkSausage);

            chkHamburger.Text = "Hamburger";
            chkHamburger.Location = new Point(10, 110);
            grp2.Controls.Add(chkHamburger);

            chkPineapple.Text = "Pineapple";
            chkPineapple.Location = new Point(10, 140);
            grp2.Controls.Add(chkPineapple);

            chkGreenPeppers.Text = "Green Peppers";
            chkGreenPeppers.Location = new Point(10, 170);
            grp2.Controls.Add(chkGreenPeppers);

            chkVeggies.Text = "Veggies";
            chkVeggies.Location = new Point(10, 200);
            grp2.Controls.Add(chkVeggies);

            chkBlackOlives.Text = "Black Olives";
            chkBlackOlives.Location = new Point(10, 230);
            grp2.Controls.Add(chkBlackOlives);

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(grp2);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.DimGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;
            Clear();

            grp.Size = new Size(150, 300);
            grp.Location = new Point(10, 10);
            grp.Text = "Drink Size";

            rdoSmallDrink.Text = "Small ($1.00)";
            rdoSmallDrink.Location = new Point(10, 20);
            grp.Controls.Add(rdoSmallDrink);

            rdoMediumDrink.Text = "Medium ($1.50)";
            rdoMediumDrink.Location = new Point(10, 50);
            grp.Controls.Add(rdoMediumDrink);

            rdoLargeDrink.Text = "Large ($2.00)";
            rdoLargeDrink.Location = new Point(10, 80);
            grp.Controls.Add(rdoLargeDrink);
            rdoLargeDrink.Checked = true;

            grp2.Size = new Size(150, 300);
            grp2.Location = new Point(170, 10);
            grp2.Text = "Drink Flavor";

            rdoCoke.Text = "Coke";
            rdoCoke.Location = new Point(10, 20);
            grp2.Controls.Add(rdoCoke);
            rdoCoke.Checked = true;

            rdoDietCoke.Text = "Diet Coke";
            rdoDietCoke.Location = new Point(10, 50);
            grp2.Controls.Add(rdoDietCoke);

            rdoMtDew.Text = "Mt Dew";
            rdoMtDew.Location = new Point(10, 80);
            grp2.Controls.Add(rdoMtDew);

            rdoDietMtDew.Text = "Diet Mt Dew";
            rdoDietMtDew.Location = new Point(10, 110);
            grp2.Controls.Add(rdoDietMtDew);

            rdoSprite.Text = "Sprite";
            rdoSprite.Location = new Point(10, 140);
            grp2.Controls.Add(rdoSprite);

            rdoRootBeer.Text = "Root Beer";
            rdoRootBeer.Location = new Point(10, 170);
            grp2.Controls.Add(rdoRootBeer);

            rdoFruitPunch.Text = "Fruit Punch";
            rdoFruitPunch.Location = new Point(10, 200);
            grp2.Controls.Add(rdoFruitPunch);

            rdoDrPepper.Text = "Dr Pepper";
            rdoDrPepper.Location = new Point(10, 230);
            grp2.Controls.Add(rdoDrPepper);

            rdoWater.Text = "Water";
            rdoWater.Location = new Point(10, 260);
            grp2.Controls.Add(rdoWater);

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(grp2);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.DimGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;
            Clear();
            
            grp.Size = new Size(150, 300);
            grp.Location = new Point(10, 10);
            grp.Text = "Number of servings";

            Label lblNumberOfServings = new Label();
            lblNumberOfServings.Text = "$2.00 per serving";
            lblNumberOfServings.Location = new Point(10, 20);
            grp.Controls.Add(lblNumberOfServings);

            cboNumberOfServings.Items.Add("1");
            cboNumberOfServings.Items.Add("2");
            cboNumberOfServings.Items.Add("3");
            cboNumberOfServings.Items.Add("4");
            cboNumberOfServings.Items.Add("5");
            cboNumberOfServings.Items.Add("6");
            cboNumberOfServings.Items.Add("7");
            cboNumberOfServings.Items.Add("8");
            cboNumberOfServings.Items.Add("9");
            cboNumberOfServings.Items.Add("10");
            cboNumberOfServings.Location = new Point(10, 50);
            grp.Controls.Add(cboNumberOfServings);
            cboNumberOfServings.SelectedIndex = 0;
            cboNumberOfServings.DropDownStyle = ComboBoxStyle.DropDownList;


            grp2.Size = new Size(150, 300);
            grp2.Location = new Point(170, 10);
            grp2.Text = "Salad Type";

            rdoCaesarSalad.Text = "Caesar Salad";
            rdoCaesarSalad.Location = new Point(10, 20);
            grp2.Controls.Add(rdoCaesarSalad);
            rdoCaesarSalad.Checked = true;

            rdoCobbSalad.Text = "Cobb Salad";
            rdoCobbSalad.Location = new Point(10, 50);
            grp2.Controls.Add(rdoCobbSalad);

            rdoChineseSalad.Text = "Chinese Salad";
            rdoChineseSalad.Location = new Point(10, 80);
            grp2.Controls.Add(rdoChineseSalad);

            rdoSantaFeSalad.Text = "Santa Fe Salad";
            rdoSantaFeSalad.Location = new Point(10, 110);
            grp2.Controls.Add(rdoSantaFeSalad);

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(grp2);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void btnBreadsticks_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.DimGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;
            Clear();

            grp.Size = new Size(150, 300);
            grp.Location = new Point(10, 10);
            grp.Text = "Breadstick Count";

            rdoFour.Text = "Four ($2.00)";
            rdoFour.Location = new Point(10, 20);
            grp.Controls.Add(rdoFour);
            rdoFour.Checked = true;

            rdoEight.Text = "Eight ($4.00)";
            rdoEight.Location = new Point(10, 50);
            grp.Controls.Add(rdoEight);

            rdoTwelve.Text = "Twelve ($5.00)";
            rdoTwelve.Location = new Point(10, 80);
            grp.Controls.Add(rdoTwelve);

            grp2.Size = new Size(150, 300);
            grp2.Location = new Point(170, 10);
            grp2.Text = "Breadstick Flavor";

            rdoGarlic.Text = "Garlic";
            rdoGarlic.Location = new Point(10, 20);
            grp2.Controls.Add(rdoGarlic);
            rdoGarlic.Checked = true;

            rdoCinnamon.Text = "Cinnamon";
            rdoCinnamon.Location = new Point(10, 50);
            grp2.Controls.Add(rdoCinnamon);

            rdoPlain.Text = "Plain";
            rdoPlain.Location = new Point(10, 80);
            grp2.Controls.Add(rdoPlain);

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(grp2);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.DimGray;
            btnCoolStuff.BackColor = Color.LightGray;
            btnRemoveItem.Enabled = false;
            Clear();

            grp.Size = new Size(306, 420);
            grp.Location = new Point(10, 10);
            grp.Text = "Specials";

            rdoTuesdaySpecial.Text = "$10 Tuesdays Box (1 Large Pizza)";
            rdoTuesdaySpecial.AutoSize = true;
            rdoTuesdaySpecial.Location = new Point(10, 20);
            grp.Controls.Add(rdoTuesdaySpecial);
            rdoTuesdaySpecial.Checked = true;

            Label lblTuesdayPizza = new Label();
            lblTuesdayPizza.Text = "Pizza Topping:";
            lblTuesdayPizza.Width = 130;
            lblTuesdayPizza.TextAlign = ContentAlignment.MiddleRight;
            lblTuesdayPizza.Location = new Point(10, 45);
            grp.Controls.Add(lblTuesdayPizza);

            cboTuesdayPizza.Items.Add("4 Cheese");
            cboTuesdayPizza.Items.Add("Hamburger");
            cboTuesdayPizza.Items.Add("Pepperoni");
            cboTuesdayPizza.Items.Add("Meat Lovers");
            cboTuesdayPizza.Items.Add("Veggie Lovers");
            cboTuesdayPizza.Location = new Point(140, 45);
            grp.Controls.Add(cboTuesdayPizza);
            cboTuesdayPizza.SelectedIndex = 0;
            cboTuesdayPizza.DropDownStyle = ComboBoxStyle.DropDownList;

            rdoDinnerSpecial.Text = "Dinner Box (1 Med. Pizza, 8 Breadsticks, 2 Large Drinks)";
            rdoDinnerSpecial.AutoSize = true;
            rdoDinnerSpecial.Location = new Point(10, 80);
            grp.Controls.Add(rdoDinnerSpecial);

            Label lblDinnerPizza = new Label();
            lblDinnerPizza.Text = "Pizza Topping: ";
            lblDinnerPizza.Width = 130;
            lblDinnerPizza.TextAlign = ContentAlignment.MiddleRight;
            lblDinnerPizza.Location = new Point(10, 105);
            grp.Controls.Add(lblDinnerPizza);

            cboDinnerPizza.Items.Add("4 Cheese");
            cboDinnerPizza.Items.Add("Hamburger");
            cboDinnerPizza.Items.Add("Pepperoni");
            cboDinnerPizza.Items.Add("Meat Lovers");
            cboDinnerPizza.Items.Add("Veggie Lovers");
            cboDinnerPizza.Location = new Point(140, 105);
            grp.Controls.Add(cboDinnerPizza);
            cboDinnerPizza.SelectedIndex = 0;
            cboDinnerPizza.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblDinnerBreadsticks = new Label();
            lblDinnerBreadsticks.Text = "Breadstick Flavor:";
            lblDinnerBreadsticks.Width = 130;
            lblDinnerBreadsticks.TextAlign = ContentAlignment.MiddleRight;
            lblDinnerBreadsticks.Location = new Point(10, 130);
            grp.Controls.Add(lblDinnerBreadsticks);

            cboDinnerBreadsticks.Items.Add("Garlic");
            cboDinnerBreadsticks.Items.Add("Cinnamon");
            cboDinnerBreadsticks.Items.Add("Plain");
            cboDinnerBreadsticks.Location = new Point(140, 130);
            grp.Controls.Add(cboDinnerBreadsticks);
            cboDinnerBreadsticks.SelectedIndex = 0;
            cboDinnerBreadsticks.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblDinnerDrink1 = new Label();
            lblDinnerDrink1.Text = "Drink #1:";
            lblDinnerDrink1.Width = 130;
            lblDinnerDrink1.TextAlign = ContentAlignment.MiddleRight;
            lblDinnerDrink1.Location = new Point(10, 155);
            grp.Controls.Add(lblDinnerDrink1);

            cboDinnerDrink1.Items.Add("Coke");
            cboDinnerDrink1.Items.Add("Diet Coke");
            cboDinnerDrink1.Items.Add("Mt Dew");
            cboDinnerDrink1.Items.Add("Diet Mt Dew");
            cboDinnerDrink1.Items.Add("Sprite");
            cboDinnerDrink1.Items.Add("Root Beer");
            cboDinnerDrink1.Items.Add("Fruit Punch");
            cboDinnerDrink1.Items.Add("Dr Pepper");
            cboDinnerDrink1.Items.Add("Water");
            cboDinnerDrink1.Location = new Point(140, 155);
            grp.Controls.Add(cboDinnerDrink1);
            cboDinnerDrink1.SelectedIndex = 0;
            cboDinnerDrink1.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblDinnerDrink2 = new Label();
            lblDinnerDrink2.Text = "Drink #2:";
            lblDinnerDrink2.Width = 130;
            lblDinnerDrink2.TextAlign = ContentAlignment.MiddleRight;
            lblDinnerDrink2.Location = new Point(10, 180);
            grp.Controls.Add(lblDinnerDrink2);

            cboDinnerDrink2.Items.Add("Coke");
            cboDinnerDrink2.Items.Add("Diet Coke");
            cboDinnerDrink2.Items.Add("Mt Dew");
            cboDinnerDrink2.Items.Add("Diet Mt Dew");
            cboDinnerDrink2.Items.Add("Sprite");
            cboDinnerDrink2.Items.Add("Root Beer");
            cboDinnerDrink2.Items.Add("Fruit Punch");
            cboDinnerDrink2.Items.Add("Dr Pepper");
            cboDinnerDrink2.Items.Add("Water");
            cboDinnerDrink2.Location = new Point(140, 180);
            grp.Controls.Add(cboDinnerDrink2);
            cboDinnerDrink2.SelectedIndex = 0;
            cboDinnerDrink2.DropDownStyle = ComboBoxStyle.DropDownList;

            rdoPartySpecial.Text = "Party Box (4 Large Pizzas, 24 Breadsticks)";
            rdoPartySpecial.AutoSize = true;
            rdoPartySpecial.Location = new Point(10, 210);
            grp.Controls.Add(rdoPartySpecial);

            Label lblPartyPizza1 = new Label();
            lblPartyPizza1.Text = "Pizza #1 Topping: ";
            lblPartyPizza1.Width = 130;
            lblPartyPizza1.TextAlign = ContentAlignment.MiddleRight;
            lblPartyPizza1.Location = new Point(10, 235);
            grp.Controls.Add(lblPartyPizza1);

            cboPartyPizza1.Items.Add("4 Cheese");
            cboPartyPizza1.Items.Add("Hamburger");
            cboPartyPizza1.Items.Add("Pepperoni");
            cboPartyPizza1.Items.Add("Meat Lovers");
            cboPartyPizza1.Items.Add("Veggie Lovers");
            cboPartyPizza1.Location = new Point(140, 235);
            grp.Controls.Add(cboPartyPizza1);
            cboPartyPizza1.SelectedIndex = 0;
            cboPartyPizza1.DropDownStyle = ComboBoxStyle.DropDownList;


            Label lblPartyPizza2 = new Label();
            lblPartyPizza2.Text = "Pizza #2 Topping: ";
            lblPartyPizza2.Width = 130;
            lblPartyPizza2.TextAlign = ContentAlignment.MiddleRight;
            lblPartyPizza2.Location = new Point(10, 260);
            grp.Controls.Add(lblPartyPizza2);

            cboPartyPizza2.Items.Add("4 Cheese");
            cboPartyPizza2.Items.Add("Hamburger");
            cboPartyPizza2.Items.Add("Pepperoni");
            cboPartyPizza2.Items.Add("Meat Lovers");
            cboPartyPizza2.Items.Add("Veggie Lovers");
            cboPartyPizza2.Location = new Point(140, 260);
            grp.Controls.Add(cboPartyPizza2);
            cboPartyPizza2.SelectedIndex = 0;
            cboPartyPizza2.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblPartyPizza3 = new Label();
            lblPartyPizza3.Text = "Pizza #3 Topping: ";
            lblPartyPizza3.Width = 130;
            lblPartyPizza3.TextAlign = ContentAlignment.MiddleRight;
            lblPartyPizza3.Location = new Point(10, 285);
            grp.Controls.Add(lblPartyPizza3);

            cboPartyPizza3.Items.Add("4 Cheese");
            cboPartyPizza3.Items.Add("Hamburger");
            cboPartyPizza3.Items.Add("Pepperoni");
            cboPartyPizza3.Items.Add("Meat Lovers");
            cboPartyPizza3.Items.Add("Veggie Lovers");
            cboPartyPizza3.Location = new Point(140, 285);
            grp.Controls.Add(cboPartyPizza3);
            cboPartyPizza3.SelectedIndex = 0;
            cboPartyPizza3.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblPartyPizza4 = new Label();
            lblPartyPizza4.Text = "Pizza #4 Topping: ";
            lblPartyPizza4.Width = 130;
            lblPartyPizza4.TextAlign = ContentAlignment.MiddleRight;
            lblPartyPizza4.Location = new Point(10, 310);
            grp.Controls.Add(lblPartyPizza4);

            cboPartyPizza4.Items.Add("4 Cheese");
            cboPartyPizza4.Items.Add("Hamburger");
            cboPartyPizza4.Items.Add("Pepperoni");
            cboPartyPizza4.Items.Add("Meat Lovers");
            cboPartyPizza4.Items.Add("Veggie Lovers");
            cboPartyPizza4.Location = new Point(140, 310);
            grp.Controls.Add(cboPartyPizza4);
            cboPartyPizza4.SelectedIndex = 0;
            cboPartyPizza4.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblPartyBreadsticks1 = new Label();
            lblPartyBreadsticks1.Text = "Breadstick Flavor: (8ct)";
            lblPartyBreadsticks1.Width = 130;
            lblPartyBreadsticks1.TextAlign = ContentAlignment.MiddleRight;
            lblPartyBreadsticks1.Location = new Point(10, 335);
            grp.Controls.Add(lblPartyBreadsticks1);

            cboPartyBreadsticks1.Items.Add("Garlic");
            cboPartyBreadsticks1.Items.Add("Cinnamon");
            cboPartyBreadsticks1.Items.Add("Plain");
            cboPartyBreadsticks1.Location = new Point(140, 335);
            grp.Controls.Add(cboPartyBreadsticks1);
            cboPartyBreadsticks1.SelectedIndex = 0;
            cboPartyBreadsticks1.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblPartyBreadsticks2 = new Label();
            lblPartyBreadsticks2.Text = "Breadstick Flavor: (8ct)";
            lblPartyBreadsticks2.Width = 130;
            lblPartyBreadsticks2.TextAlign = ContentAlignment.MiddleRight;
            lblPartyBreadsticks2.Location = new Point(10, 360);
            grp.Controls.Add(lblPartyBreadsticks2);

            cboPartyBreadsticks2.Items.Add("Garlic");
            cboPartyBreadsticks2.Items.Add("Cinnamon");
            cboPartyBreadsticks2.Items.Add("Plain");
            cboPartyBreadsticks2.Location = new Point(140, 360);
            grp.Controls.Add(cboPartyBreadsticks2);
            cboPartyBreadsticks2.SelectedIndex = 0;
            cboPartyBreadsticks2.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblPartyBreadsticks3 = new Label();
            lblPartyBreadsticks3.Text = "Breadstick Flavor: (8ct)";
            lblPartyBreadsticks3.Width = 130;
            lblPartyBreadsticks3.TextAlign = ContentAlignment.MiddleRight;
            lblPartyBreadsticks3.Location = new Point(10, 385);
            grp.Controls.Add(lblPartyBreadsticks3);

            cboPartyBreadsticks3.Items.Add("Garlic");
            cboPartyBreadsticks3.Items.Add("Cinnamon");
            cboPartyBreadsticks3.Items.Add("Plain");
            cboPartyBreadsticks3.Location = new Point(140, 385);
            grp.Controls.Add(cboPartyBreadsticks3);
            cboPartyBreadsticks3.SelectedIndex = 0;
            cboPartyBreadsticks3.DropDownStyle = ComboBoxStyle.DropDownList;

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(btnAddItem);
            //rdoPartySpecial.Click += RdoPartySpecial_Click;
            //rdoTuesdaySpecial.Click += RdoTuesdaySpecial_Click;
            //rdoDinnerSpecial.Click += RdoDinnerSpecial_Click;
        }

        private void btnCoolStuff_Click(object sender, EventArgs e)
        {
            btnPizza.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;
            btnSalads.BackColor = Color.LightGray;
            btnBreadsticks.BackColor = Color.LightGray;
            btnSpecials.BackColor = Color.LightGray;
            btnCoolStuff.BackColor = Color.DimGray;
            btnRemoveItem.Enabled = false;
            Clear();

            grp.Size = new Size(306, 380);
            grp.Location = new Point(10, 10);
            grp.Text = "Cool Stuff ($25.00)";

            
            pbxShirt1.Size = new Size(120, 120);
            pbxShirt1.Location = new Point(10, 20);
            pbxShirt1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxShirt1.Image = Resource1.Shirt1;
            pbxShirt1.Click += PbxShirt1_Click1;
            grp.Controls.Add(pbxShirt1);
            
            rdoShirt1.Location = new Point(65, 140);
            rdoShirt1.Width = 15;
            grp.Controls.Add(rdoShirt1);
            rdoShirt1.Checked = true;

            pbxShirt2.Size = new Size(120, 120);
            pbxShirt2.Location = new Point(160, 20);
            pbxShirt2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxShirt2.Image = Resource1.Shirt2;
            pbxShirt2.Click += PbxShirt2_Click;
            grp.Controls.Add(pbxShirt2);

            rdoShirt2.Location = new Point(215, 140);
            rdoShirt2.Width = 15;
            grp.Controls.Add(rdoShirt2);

            pbxShirt3.Size = new Size(120, 120);
            pbxShirt3.Location = new Point(10, 180);
            pbxShirt3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxShirt3.Image = Resource1.Shirt3;
            pbxShirt3.Click += PbxShirt3_Click;
            grp.Controls.Add(pbxShirt3);

            rdoShirt3.Location = new Point(65, 300);
            rdoShirt3.Width = 15;
            grp.Controls.Add(rdoShirt3);

            pbxShirt4.Size = new Size(120, 120);
            pbxShirt4.Location = new Point(160, 180);
            pbxShirt4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxShirt4.Image = Resource1.Shirt4;
            pbxShirt4.Click += PbxShirt4_Click;
            grp.Controls.Add(pbxShirt4);

            rdoShirt4.Location = new Point(215, 300);
            rdoShirt4.Width = 15;
            grp.Controls.Add(rdoShirt4);

            Label lblShirtSize = new Label();
            lblShirtSize.Text = "Shirt Size:";
            lblShirtSize.Width = 130;
            lblShirtSize.TextAlign = ContentAlignment.MiddleRight;
            lblShirtSize.Location = new Point(10, 340);
            grp.Controls.Add(lblShirtSize);

            cboShirtSize.Items.Add("XS");
            cboShirtSize.Items.Add("S");
            cboShirtSize.Items.Add("M");
            cboShirtSize.Items.Add("L");
            cboShirtSize.Items.Add("XL");
            cboShirtSize.Items.Add("2XL");
            cboShirtSize.Items.Add("3XL");
            cboShirtSize.Location = new Point(140, 340);
            grp.Controls.Add(cboShirtSize);
            cboShirtSize.SelectedIndex = 3;
            cboShirtSize.DropDownStyle = ComboBoxStyle.DropDownList;

            Button btnAddItem = new Button();
            btnAddItem.Text = "Add Item";
            btnAddItem.Click += new EventHandler(btnAddItem_Click);

            flowLayoutPanel1.Controls.Add(grp);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //List<Animal> zooResidents = new List<Animal>();

            //zooResidents.Add(new Lion(2222, "Leo"));
            btnRemoveItem.Enabled = false;
            if (btnPizza.BackColor == Color.DimGray)
            {
                PizzaClass pizza = new PizzaClass();
                //Product p;
                string toppingsString = "";
                if (rdoSmallPizza.Checked)
                {
                    pizza.PizzaSize = "Small";
                    Product.productSize = pizza.PizzaSize;
                }
                else if (rdoMediumPizza.Checked)
                {
                    pizza.PizzaSize = "Medium";
                    Product.productSize = pizza.PizzaSize;
                }
                else if(rdoLargePizza.Checked)
                {
                    pizza.PizzaSize = "Large";
                    Product.productSize = pizza.PizzaSize;
                }
                if (chkCheese.Checked)
                {
                    toppingsString += "4 Cheese, ";
                }
                if (chkPepperoni.Checked)
                {
                    toppingsString += "Pepperoni, ";
                }
                if (chkSausage.Checked)
                {
                    toppingsString += "Sausage, ";
                }
                if (chkHamburger.Checked)
                {
                    toppingsString += "Hamburger, ";
                }
                if (chkPineapple.Checked)
                {
                    toppingsString += "Pineapple, ";
                }
                if (chkGreenPeppers.Checked)
                {
                    toppingsString += "Green Peppers, ";
                }
                if (chkVeggies.Checked)
                {
                    toppingsString += "Veggies, ";
                }
                if (chkBlackOlives.Checked)
                {
                    toppingsString += "Black Olives, ";
                }
                //p.productDescription = toppingsString;
                //p.productID = "Pizza";
                //p.productPrice = p.PizzaPrice(p.productSize);
                pizza.PizzaID = "Pizza";
                pizza.PizzaDescription = toppingsString;
                pizza.PizzaPrice(pizza.PizzaSize);
                Product.productID = pizza.PizzaID;
                Product.productDescription = pizza.PizzaDescription;
                Product.productPrice = Convert.ToDecimal(pizza.PizzaPrice(pizza.PizzaSize));
                //allOrderItems.Add(Product(p.productID, p.productSize, p.productDescription));
                allOrderItems.Add(pizza);
                Product.allOrderPrices.Add(Product.GetPrice());
                //MessageBox.Show();
            }
            if (btnDrinks.BackColor == Color.DimGray)
            {
                DrinksClass drink = new DrinksClass();
                if (rdoSmallDrink.Checked)
                {
                    drink.DrinkSize = "Small";
                    Product.productSize = drink.DrinkSize;
                }
                else if (rdoMediumDrink.Checked)
                {
                    drink.DrinkSize = "Medium";
                    Product.productSize = drink.DrinkSize;
                }
                else if(rdoLargeDrink.Checked)
                {
                    drink.DrinkSize = "Large";
                    Product.productSize = drink.DrinkSize;
                }

                if (rdoCoke.Checked)
                {
                    drink.DrinkDescription = "Coke";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoDietCoke.Checked)
                {
                    drink.DrinkDescription = "Diet Coke";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoMtDew.Checked)
                {
                    drink.DrinkDescription = "Mt Dew";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoDietMtDew.Checked)
                {
                    drink.DrinkDescription = "Diet Mt Dew";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoSprite.Checked)
                {
                    drink.DrinkDescription = "Sprite";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoRootBeer.Checked)
                {
                    drink.DrinkDescription = "Root Beer";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoFruitPunch.Checked)
                {
                    drink.DrinkDescription = "Fruit Punch";
                    Product.productSize = drink.DrinkDescription;
                }
                else if (rdoDrPepper.Checked)
                {
                    drink.DrinkDescription = "Dr Pepper";
                    Product.productSize = drink.DrinkDescription;
                }
                else if(rdoWater.Checked)
                {
                    drink.DrinkDescription = "Water";
                    Product.productSize = drink.DrinkDescription;
                }
                drink.DrinkID = "Drink";
                drink.DrinkPrice(drink.DrinkSize);
                Product.productID = drink.DrinkID;
                Product.productPrice = Convert.ToDecimal(drink.DrinkPrice(drink.DrinkSize));
                allOrderItems.Add(drink);
                Product.allOrderPrices.Add(Product.GetPrice());
            }
            if (btnSalads.BackColor == Color.DimGray)
            {
                SaladsClass salad = new SaladsClass();
                if (cboNumberOfServings.Text != "")
                {
                    try
                    {
                        salad.SaladServings = Convert.ToInt16(cboNumberOfServings.Text);
                    }
                    catch (FormatException f)
                    {
                        MessageBox.Show(f.Message);
                    }
                    catch (Exception  x)
                    {
                        MessageBox.Show(x.Message);
                    }
                    
                }
                Product.productSize = cboNumberOfServings.Text;

                if (rdoCaesarSalad.Checked)
                {
                    salad.SaladType = "Caesar";
                    Product.productDescription = salad.SaladType;
                }
                else if (rdoCobbSalad.Checked)
                {
                    salad.SaladType = "Cobb";
                    Product.productDescription = salad.SaladType;
                }
                else if (rdoChineseSalad.Checked)
                {
                    salad.SaladType = "Chinese";
                    Product.productDescription = salad.SaladType;
                }
                else if(rdoSantaFeSalad.Checked)
                {
                    salad.SaladType = "Santa Fe";
                    Product.productDescription = salad.SaladType;
                }
                salad.SaladID = "Salad";
                salad.SaladPrice(salad.SaladServings);
                Product.productID = salad.SaladID;
                Product.productPrice = Convert.ToDecimal(salad.SaladPrice(salad.SaladServings));
                allOrderItems.Add(salad);
                Product.allOrderPrices.Add(Product.GetPrice());
            }
            if (btnBreadsticks.BackColor == Color.DimGray)
            {
                BreadsticksClass breadstick = new BreadsticksClass();
                if (rdoFour.Checked)
                {
                    breadstick.BreadstickCount = "Four";
                    Product.productSize = breadstick.BreadstickCount;
                }
                else if (rdoEight.Checked)
                {
                    breadstick.BreadstickCount = "Eight";
                    Product.productSize = breadstick.BreadstickCount;
                }
                else if(rdoTwelve.Checked)
                {
                    breadstick.BreadstickCount = "Twelve";
                    Product.productSize = breadstick.BreadstickCount;
                }
                if (rdoGarlic.Checked)
                {
                    breadstick.BreadstickDescription = "Garlic";
                    Product.productDescription = breadstick.BreadstickDescription;
                }
                else if (rdoCinnamon.Checked)
                {
                    breadstick.BreadstickDescription = "Cinnamon";
                    Product.productDescription = breadstick.BreadstickDescription;
                }
                else if(rdoPlain.Checked)
                {
                    breadstick.BreadstickDescription = "Plain";
                    Product.productDescription = breadstick.BreadstickDescription;
                }
                breadstick.BreadstickID = "Breadstick";
                breadstick.BreadstickPrice(breadstick.BreadstickCount);
                Product.productID = breadstick.BreadstickID;
                Product.productPrice = Convert.ToDecimal(breadstick.BreadstickPrice(breadstick.BreadstickCount));
                allOrderItems.Add(breadstick);
                Product.allOrderPrices.Add(Product.GetPrice());
            }
            if (btnSpecials.BackColor == Color.DimGray)
            {
                SpecialsClass specials = new SpecialsClass();
                string specialsString = "";
                if (rdoTuesdaySpecial.Checked)
                {
                    specials.SpecialType = "Tuesday Special";
                    specialsString = (cboTuesdayPizza.Text + " pizza");
                    specials.SpecialDescription = specialsString;
                    Product.productSize = specials.SpecialType;
                    Product.productDescription = specials.SpecialDescription;
                }
                else if (rdoDinnerSpecial.Checked)
                {
                    specials.SpecialType = "Dinner Special";
                    specialsString = (cboDinnerPizza.Text + " pizza, " + cboDinnerBreadsticks.Text + 
                        " breadsticks, LG " + cboDinnerDrink1.Text + ", LG " + cboDinnerDrink2.Text);
                    specials.SpecialDescription = specialsString;
                    Product.productSize = specials.SpecialType;
                    Product.productDescription = specials.SpecialDescription;
                }
                else if(rdoPartySpecial.Checked)
                {
                    specials.SpecialType = "Party Special";
                    specialsString = cboPartyPizza1.Text + ", " + cboPartyPizza2.Text + ", " +
                        cboPartyPizza3.Text + ", " + cboPartyPizza4.Text + ", " + cboPartyBreadsticks1.Text + ", " +
                        cboPartyBreadsticks2.Text + ", " + cboPartyBreadsticks3.Text;
                    specials.SpecialDescription = specialsString;
                    Product.productSize = specials.SpecialType;
                    Product.productDescription = specials.SpecialDescription;
                }
                specials.SpecialID = "Special";
                specials.SpecialPrice(specials.SpecialType);
                Product.productID = specials.SpecialID;
                Product.productPrice = Convert.ToDecimal(specials.SpecialPrice(specials.SpecialType));
                allOrderItems.Add(specials);
                Product.allOrderPrices.Add(Product.GetPrice());
            }
            if(btnCoolStuff.BackColor == Color.DimGray)
            {
                CoolStuffClass coolStuff = new CoolStuffClass();
                string size = "";
                size = cboShirtSize.Text;
                coolStuff.ShirtSize = size;
                Product.productSize = coolStuff.ShirtSize;

                if (rdoShirt1.Checked)
                {
                    coolStuff.ShirtDescription = "Shirt #1";
                    Product.productDescription = coolStuff.ShirtDescription;
                }
                else if (rdoShirt2.Checked)
                {
                    coolStuff.ShirtDescription = "Shirt #2";
                    Product.productDescription = coolStuff.ShirtDescription;
                }
                else if (rdoShirt3.Checked)
                {
                    coolStuff.ShirtDescription = "Shirt #3";
                    Product.productDescription = coolStuff.ShirtDescription;
                }
                else if (rdoShirt4.Checked)
                {
                    coolStuff.ShirtDescription = "Shirt #4";
                    Product.productDescription = coolStuff.ShirtDescription;
                }
                coolStuff.ShirtID = "Shirt";
                coolStuff.ShirtPrice();
                Product.productID = coolStuff.ShirtID;
                Product.productPrice = Convert.ToDecimal(coolStuff.ShirtPrice());
                allOrderItems.Add(coolStuff);
                Product.allOrderPrices.Add(Product.GetPrice());
            }

            ShowAllOrderItems();
        }

        private void ShowAllOrderItems() 
        {
            lstOrderItems.Items.Clear();

            foreach (Product p in allOrderItems)
            {
                lstOrderItems.Items.Add(p.ToString());
            }
            lstOrderItems.Items.Add("\n");
            lstOrderItems.Items.Add("Total after tax: " + Order.CalculateTax(Order.CalculateTotal()).ToString("C2"));
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstOrderItems);
            selectedItems = lstOrderItems.SelectedItems;

            if (lstOrderItems.SelectedIndex != -1)
            {
                allOrderItems.RemoveAt(lstOrderItems.SelectedIndex);
                Product.allOrderPrices.RemoveAt(lstOrderItems.SelectedIndex);

                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lstOrderItems.Items.Remove(selectedItems[i]);
                }

            }
            btnRemoveItem.Enabled = false;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (Product p in allOrderItems)
            {
                
                message += (p + "\n");
            }
            MessageBox.Show("Receipt: " + "\n" + message + "\n\n" + "Total after tax: " +  Order.CalculateTax(Order.CalculateTotal()).ToString("C2"));
            OrderDA.AddOrder();
        }

        public void Clear()
        {
            flowLayoutPanel1.Controls.Clear();
            grp.Text = "";
            grp.Controls.Clear();
            grp2.Text = "";
            grp2.Controls.Clear();
            cboNumberOfServings.Items.Clear();
            cboTuesdayPizza.Items.Clear();
            cboDinnerPizza.Items.Clear();
            cboDinnerBreadsticks.Items.Clear();
            cboDinnerDrink1.Items.Clear();
            cboDinnerDrink2.Items.Clear(); 
            cboPartyPizza1.Items.Clear();
            cboPartyPizza2.Items.Clear();
            cboPartyPizza3.Items.Clear();
            cboPartyPizza4.Items.Clear();
            cboPartyBreadsticks1.Items.Clear();
            cboPartyBreadsticks2.Items.Clear();
            cboPartyBreadsticks3.Items.Clear();
            cboShirtSize.Items.Clear();
        }

        private void lstOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveItem.Enabled = true;
            

        }

        private void PbxShirt4_Click(object sender, EventArgs e)
        {
            rdoShirt4.Checked = true;
        }

        private void PbxShirt3_Click(object sender, EventArgs e)
        {
            rdoShirt3.Checked = true;
        }

        private void PbxShirt2_Click(object sender, EventArgs e)
        {
            rdoShirt2.Checked = true;
        }

        private void PbxShirt1_Click1(object sender, EventArgs e)
        {
            rdoShirt1.Checked = true;
        }
    }
}
