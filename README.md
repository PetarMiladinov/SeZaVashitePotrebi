# SeZaVashitePotrebi

Windows Forms App that allows you as an User to login and buy or rent some of the items that are listed on the App. You can search
by category or by name of the product. We were going for something like pazar3.mkd (https://www.pazar3.mk/).


## 1. Window Form App Architecture
	- Classes
		- AppUser
		- Item
	- Forms
		- Form1 (Main Form)
		- LoginForm
		- RegisterForm
		- MyAccountForm
		- CartForm
		- PostItemForm
		- ItemDetailsForm
	- ItemDisplayControl
	
	- Classes file contains the objects of the application (AppUser, Item). Both of the classes have their properties like name,
	price, address, etc. For categorizing the items Enumarates are used, for the distinction of the user if they are sellers or buyers
	a bool value is used (isSeller). //maybe add some code here
	
	- Every form named accordincly to its purpose. Only the Form1 is used as main connecting form. The list of objects
	(List<Item>, List<AppUser>, List<ItemDisplayControl>) are created in Form1 and passed around together with the information of
	the loggedIn user.
	
	- ItemDisplayControl is used for creating the card like ads for the application. In its constructor gets 3 arguments (item, user, parentForm). The UI is constructed of labels for the basic info of the item and an image. It has some events, like click event that opens
a new form displaying the full description of the item.
	
    
    
    
    
```cs
public partial class ItemDisplayContorl : UserControl
{
    public Item item;
    private AppUser LoggedIn;
    private Form parentForm;
    public bool SelectedForPurchase;
    public CartForm CartFormInstance { get; set; }


    public ItemDisplayContorl(Item item, AppUser user, Form parentForm)
    {
        InitializeComponent();

        this.item = item;
        this.LoggedIn = user;
        this.parentForm = parentForm;

        lblCategory.Text = item.Category.ToString();
        lblName.Text = item.Name.ToString();
        lblPrice.Text = item.Price.ToString();
        lblType.Text = item.Type.ToString();
        pictureBox1.ImageLocation = item.Image;

        btnRemoveFromCart.Visible = false;

        if (parentForm.Text.Contains("Cart"))
        {
            btnRemoveFromCart.Visible = true;
        }

    }

    private void ItemDisplayContorl_Click(object sender, EventArgs e)
    {
        ItemDetails itemDetailsForm = new ItemDetails(item);
        itemDetailsForm.ShowDialog();

    }

    private void ItemDisplayContorl_Load(object sender, EventArgs e)
    {

    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        LoggedIn.cartItems.Add(item);
        btnAddToCart.Enabled = false;
    }

    private void btnRemoveFromCart_Click(object sender, EventArgs e)
    {
        LoggedIn.cartItems.Remove(item);
        parentForm.Controls.Remove(this);

        //good way to check in which form we are working
        if (parentForm is CartForm cartForm)
        {
            cartForm.RefreshCart();
        }
    }
}
```
	
## 2. Quick application Tutorial
 - Firstly the Form1 is opened, displaying the items that are posted on the application.
	![Alt Image text](/screenshots/form1.png?raw=true "Form1")
 - Then you can either REGISTER or LOGIN on the applicaiton. Depending of your situation, lets say you first need to register
the register form will be displayed (you can register as a buyer or seller).
	![Alt Image text](/screenshots/registerForm.png?raw=true "RegisterForm")
 - After that you can login clicking on the LOGIN button and open a simple login form.
	![Alt Image text](/screenshots/loginForm.png?raw=true "LoginForm")
 - You can search for given item name or by category. (after you choose a category press the SEARCH button)
 - If you registered as a seller there will be a PostItem button, which by clicking it opens the POSTITEM form.
	![Alt Image text](/screenshots/postItemForm.png?raw=true "PostItemForm")
 - By clicking the MyAccount button, MyAccountForm is opened where the user can track the products ordered/posted/bought.
	![Alt Image text](/screenshots/myAccountForm.png?raw=true "MyAccount")
 - If you registered as a buyer, a shopping cart functionality is available.
	![Alt Image text](/screenshots/cartForm.png?raw=true "Shopping Cart")
