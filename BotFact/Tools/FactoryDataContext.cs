using BotFactory.Common.Interface;
using BotFactory.Common.Tools;
using BotFactory.Factories;
using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BotFactory.Tools
{
    public class FactoryDataContext : INotifyPropertyChanged
    {
        private List<Type> _models = new List<Type>() { typeof(HAL), typeof(R2D2), typeof(T_800), typeof(Wall_E) };

        public List<Type> Models
        {
            get { return _models; }
        }

        public String Name { get; set; }

        private IUnitFactory _builder;


        private ObservableCollection<IFactoryQueueElement> _Queue;
        private ObservableCollection<ITestingUnit> _Storage;

        public IUnitFactory Builder
        {
            get
            {
                return _builder;
            }
            set
            {
                SetField(ref _builder, value, "Builder");
                ForceUpdate();
            }

        }

        public int QueueCapacity
        {
            get
            {
                return _builder.QueueCapacity;
            }
            set
            {
                OnPropertyChanged("QueueCapacity");
            }
        }

        public int StorageCapacity
        {
            get
            {
                return _builder.StorageCapacity;
            }
            set
            {
                OnPropertyChanged("StorageCapacity");
            }
        }

        public TimeSpan QueueTime
        {
            get
            {
                return _builder.QueueTime;
            }
            set
            {
                OnPropertyChanged("QueueTime");
            }
        }

        public int QueueFreeSlots
        {
            get
            {
                return _builder.QueueFreeSlots;
            }
            set
            {
                OnPropertyChanged("QueueFreeSlots");
            }
        }

        public int StorageFreeSlots
        {
            get
            {
                return _builder.StorageFreeSlots;
            }
            set
            {
                OnPropertyChanged("StorageFreeSlots");
            }
        }

        public ObservableCollection<IFactoryQueueElement> Queue
        {
            get
            {
                return _Queue;
            }
            set
            {
                OnPropertyChanged(nameof(_Queue));
            }
        }

        public ObservableCollection<ITestingUnit> Storage
        {
            get
            {
                return _Storage;
            }
            set
            {
                OnPropertyChanged(nameof(_Storage));
            }
        }

        public FactoryDataContext() { }
        public FactoryDataContext(UnitFactory factory){
            foreach (IFactoryQueueElement element in factory.Queue)
                Queue.Add(element);
            foreach (ITestingUnit unit in factory.Storage)
                Storage.Add(unit);

        }



        public void ForceUpdate()
        {
            if (Builder != null) 
            {
                Queue = null;
                Storage = null;
                QueueFreeSlots = 0;
                StorageFreeSlots = 0;
                QueueTime = TimeSpan.FromSeconds(0);
            }
        }

        #region INotifyPropertyChanged Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        
        #endregion
    }
}
