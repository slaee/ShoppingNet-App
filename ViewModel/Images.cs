using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Shop.Model;
using Xamarin.Forms;

namespace Shop.ViewModel
{
    public class Images : INotifyPropertyChanged
    {
        readonly IList<ImageData> source;
        
        public ObservableCollection<ImageData> ImageDatas { get; private set; }
        public IList<ImageData> EmptyImageDatas { get; private set; }

        public ImageData PreviousImage { get; set; }
        public ImageData CurrentImage { get; set; }
        public ImageData CurrentItem { get; set; }
        public int PreviousPosition { get; set; }
        public int CurrentPosition { get; set; }
        public int Position { get; set; }

        public ICommand ItemChangedCommand => new Command<ImageData>(ItemChanged);
        public ICommand PositionChangedCommand => new Command<int>(PositionChanged);
        public ICommand DeleteCommand => new Command<ImageData>(RemoveMonkey);
        public ICommand FavoriteCommand => new Command<ImageData>(FavoriteImage);

        public Images()
        {
            source = new List<ImageData>();
            CreateMonkeyCollection();

            CurrentItem = ImageDatas.Skip(3).FirstOrDefault();
            OnPropertyChanged("CurrentItem");
            Position = 3;
            OnPropertyChanged("Position");
        }

        void CreateMonkeyCollection()
        {
            source.Add(new ImageData
            {
                btn1Visible = true,
                btn2Visible = false,
                ImageSource = "assets/img/page1.jpg"
            });

            source.Add(new ImageData
            {
                btn1Visible = true,
                btn2Visible = false,
                ImageSource = "assets/img/page2.jpg"
            });

            source.Add(new ImageData
            {
                btn1Visible = true,
                btn2Visible = false,
                ImageSource = "assets/img/second_page.jpg"
            });

            source.Add(new ImageData
            {
                btn1Visible = true,
                btn2Visible = false,
                ImageSource = "assets/img/fourth.jpg"
            });

            source.Add(new ImageData
            {
                btn1Visible = true,
                btn2Visible = false,
                ImageSource = "assets/img/third.jpg"
            });
            
            source.Add(new ImageData
            {
                btn1Visible = false,
                btn2Visible = true,
                ImageSource = "assets/img/Second.jpg"
            });
            

            ImageDatas = new ObservableCollection<ImageData>(source);
        }


        void ItemChanged(ImageData item)
        {
            PreviousImage = CurrentImage;
            CurrentImage = item;
            OnPropertyChanged("PreviousImage");
            OnPropertyChanged("CurrentImage");
        }

        void PositionChanged(int position)
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
            OnPropertyChanged("PreviousPosition");
            OnPropertyChanged("CurrentPosition");
        }

        void RemoveMonkey(ImageData image)
        {
            if (ImageDatas.Contains(image))
            {
                ImageDatas.Remove(image);
            }
        }

        void FavoriteImage(ImageData image)
        {
            image.IsFavorite = !image.IsFavorite;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
