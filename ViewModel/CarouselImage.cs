using System;
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
    public class CarouselImage : INotifyPropertyChanged
    {
        readonly IList<CarouselImageData> source;
        
        public ObservableCollection<CarouselImageData> CarouselImageDatas { get; private set; }
        public IList<CarouselImageData> EmptyCarouselImageDatas { get; private set; }

        public CarouselImageData PreviousImage { get; set; }
        public CarouselImageData CurrentImage { get; set; }
        public CarouselImageData CurrentItem { get; set; }
        public int PreviousPosition { get; set; }
        public int CurrentPosition { get; set; }
        public int Position { get; set; }

        public ICommand ItemChangedCommand => new Command<CarouselImageData>(ItemChanged);
        public ICommand PositionChangedCommand => new Command<int>(PositionChanged);
        public ICommand DeleteCommand => new Command<CarouselImageData>(RemoveMonkey);
        public ICommand FavoriteCommand => new Command<CarouselImageData>(FavoriteImage);

        public CarouselImage()
        {
            source = new List<CarouselImageData>();
            CreateMonkeyCollection();
            Position = 1;
            
        }

        void CreateMonkeyCollection()
        {
            source.Add(new CarouselImageData
            {
                ImageUrl = "assets/img/logo2.jpg"
            });

            source.Add(new CarouselImageData
            {
                
                
                ImageUrl = "assets/img/Pickup.jpg"
            });

            source.Add(new CarouselImageData
            {
                
                
                ImageUrl = "assets/img/driver.jpg"
            });

            source.Add(new CarouselImageData
            {
                
                
                ImageUrl = "assets/img/fourth.jpg"
            });

            source.Add(new CarouselImageData
            {
                
                
                ImageUrl = "assets/img/third.jpg"
            });
            
            source.Add(new CarouselImageData
            {
                ImageUrl = "assets/img/Second.jpg"
            });
            

            CarouselImageDatas = new ObservableCollection<CarouselImageData>(source);
        }

        void ItemChanged(CarouselImageData item)
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

        void RemoveMonkey(CarouselImageData image)
        {
            if (CarouselImageDatas.Contains(image))
            {
                CarouselImageDatas.Remove(image);
            }
        }

        void FavoriteImage(CarouselImageData image)
        {
            image.IsFavor = !image.IsFavor;
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
