using System;
using System.Windows.Forms;
using NodorumSolutio.ApplicationFramework;

namespace Demo
{
    public partial class SimpleForm : Form
    {
        private BindingListView<Item> itemsView;

        public SimpleForm()
        {
            InitializeComponent();

            LoadFeed();
        }

        private void LoadFeed()
        {
            // Get the BBC news RSS feed
            Feed feed = new Feed("http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/front_page/rss.xml");
            feed.Update();

            // Create a view of the items
            itemsView = new BindingListView<Item>(feed.Items);
            // Make the grid display this view
            itemsGrid.DataSource = itemsView;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change the filter of the view.
            itemsView.ApplyFilter(
                delegate(Item item)
                {
                    // uses ToLower() to ignore case of text.
                    return item.Title.ToLower().Contains(filterTextBox.Text.ToLower());
                }
            );
        }
    }
}