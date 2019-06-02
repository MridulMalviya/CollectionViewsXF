using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewsXF
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public StackLayout layout { get; set; }
        public CollectionView collectionView { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        int value = 0;
        public MainViewModel(StackLayout stackLayout, CollectionView cv)
        {
            layout = stackLayout;
            collectionView = cv;
            DisplayCount(0);
            Device.StartTimer(TimeSpan.FromSeconds(3),CallMeBack);
            value = 1;
            
        }

        private bool CallMeBack()
        {
            if(value<=6)
            {
                DisplayCount(value);
                value++;
                return true;
            }
           
            return false;
        }

        private void DisplayCount(int v)
        {

            switch (v)
            {
                case 1:
                    collectionView.ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list1 = new List<PersonName>();
                    list1.Add(new PersonName("1"));
                    NameList = new ObservableCollection<PersonName>(list1);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    break;

                case 2:
                    collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list2 = new List<PersonName>();
                    list2.Add(new PersonName("1"));
                    list2.Add(new PersonName("2"));
                    NameList = new ObservableCollection<PersonName>(list2);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    break;
                case 3:
                    collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list3 = new List<PersonName>();
                    list3.Add(new PersonName("1"));
                    list3.Add(new PersonName("2"));
                    list3.Add(new PersonName("3"));
                    NameList = new ObservableCollection<PersonName>(list3);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    break;
                case 4:
                    collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list4 = new List<PersonName>();
                    list4.Add(new PersonName("1"));
                    list4.Add(new PersonName("2"));
                    list4.Add(new PersonName("3"));
                    list4.Add(new PersonName("4"));
                    NameList = new ObservableCollection<PersonName>(list4);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    NameList = new ObservableCollection<PersonName>(list4);
                    break;
                case 5:
                    collectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list5 = new List<PersonName>();
                    list5.Add(new PersonName("1"));
                    list5.Add(new PersonName("2"));
                    list5.Add(new PersonName("3"));
                    list5.Add(new PersonName("4"));
                    list5.Add(new PersonName("5"));
                    NameList = new ObservableCollection<PersonName>(list5);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    break;
                case 6:
                    collectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
                    layout?.Children.Clear();
                    NameList?.Clear();
                    List<PersonName> list6 = new List<PersonName>();
                    list6.Add(new PersonName("1"));
                    list6.Add(new PersonName("2"));
                    list6.Add(new PersonName("3"));
                    list6.Add(new PersonName("4"));
                    list6.Add(new PersonName("5"));
                    list6.Add(new PersonName("6"));
                    NameList = new ObservableCollection<PersonName>(list6);
                    collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");
                    layout?.Children.Add(collectionView);
                    break;
            }
        }


        //private void DisplayCount(int v)
        //{

        //    switch (v)
        //    {
        //        case 1:

        //            collectionView.ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list1 = new List<PersonName>();
        //            list1.Add(new PersonName("1"));
        //            NameList = new ObservableCollection<PersonName>(list1);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };

        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };


        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            break;

        //        case 2:
        //            collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list2 = new List<PersonName>();
        //            list2.Add(new PersonName("1"));
        //            list2.Add(new PersonName("2"));
        //            NameList = new ObservableCollection<PersonName>(list2);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };
        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };
        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            break;
        //        case 3:
        //            collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list3 = new List<PersonName>();
        //            list3.Add(new PersonName("1"));
        //            list3.Add(new PersonName("2"));
        //            list3.Add(new PersonName("3"));
        //            NameList = new ObservableCollection<PersonName>(list3);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };
        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };
        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            break;
        //        case 4:
        //            collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list4 = new List<PersonName>();
        //            list4.Add(new PersonName("1"));
        //            list4.Add(new PersonName("2"));
        //            list4.Add(new PersonName("3"));
        //            list4.Add(new PersonName("4"));
        //            NameList = new ObservableCollection<PersonName>(list4);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };
        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };
        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            NameList = new ObservableCollection<PersonName>(list4);
        //            break;
        //        case 5:
        //            collectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list5= new List<PersonName>();
        //            list5.Add(new PersonName("1"));
        //            list5.Add(new PersonName("2"));
        //            list5.Add(new PersonName("3"));
        //            list5.Add(new PersonName("4"));
        //            list5.Add(new PersonName("5"));
        //            NameList = new ObservableCollection<PersonName>(list5);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };
        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };
        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            break;
        //        case 6:
        //            collectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
        //            layout?.Children.Clear();
        //            NameList?.Clear();
        //            List<PersonName> list6 = new List<PersonName>();
        //            list6.Add(new PersonName("1"));
        //            list6.Add(new PersonName("2"));
        //            list6.Add(new PersonName("3"));
        //            list6.Add(new PersonName("4"));
        //            list6.Add(new PersonName("5"));
        //            list6.Add(new PersonName("6"));

        //            NameList = new ObservableCollection<PersonName>(list6);

        //            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "NameList");

        //            collectionView.ItemTemplate = new DataTemplate(() =>
        //            {
        //                Frame frame = new Frame { BorderColor = Color.Black, CornerRadius = 0f, HasShadow = false, BackgroundColor = Color.LightGray };
        //                Grid grid = new Grid { RowSpacing = 10 };
        //                Label nameLabel = new Label
        //                {
        //                    FontAttributes = FontAttributes.Bold,
        //                    HorizontalOptions = LayoutOptions.Center,
        //                    VerticalOptions = LayoutOptions.Center,
        //                    LineBreakMode = LineBreakMode.WordWrap
        //                };
        //                nameLabel.SetBinding(Label.TextProperty, "FirstName");
        //                grid.Children.Add(nameLabel);
        //                frame.Content = grid;
        //                return frame;
        //            });

        //            layout?.Children.Add(collectionView);
        //            break;

        //    }
        //}

        private int _span;
        public int Span
        {
            get => _span;
            set
            {
                _span = value;
                RaisePropertyChanged("Span");
            }
        }



        private ObservableCollection<PersonName> _nameList;
        public ObservableCollection<PersonName> NameList
        {
            get => _nameList;
            set
            {
                _nameList = value;
                RaisePropertyChanged("NameList");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }



    public class PersonName
    {
        private string firstName;


        public PersonName(string first)
        {
            this.firstName = first;

        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


    }
}
