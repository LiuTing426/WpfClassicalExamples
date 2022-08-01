using Demo73.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo73.ViewModels
{
    //① 继承INotifyPropertyChanged
    public class MainViewModel : INotifyPropertyChanged
    {
        //④ 右键 MainViewModel->快速操作和重构 -> 添加构造函数
        public MainViewModel()
        {
            //⑨ 进行初始化
            UserCollection = new ObservableCollection<MainModel>
            {
                new MainModel{FirstName="User",LastName="1"},
                new MainModel{FirstName="User",LastName="2"},
                new MainModel{FirstName="User",LastName="3"},
                new MainModel{FirstName="User",LastName="4"}
            };

            NewUserDetail = new MainModel();
        }

        //② 实现接口
        public event PropertyChangedEventHandler PropertyChanged;

        // ③ 自己添加
        public void OnPropertyChanged(string propertyName)
        {
            //判断是否为空，不为空就调用invoke
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //⑤ 定义属性

        //⑥ 右键selectedUser ->快速操作和重构 -> 封装字段（但仍使用字段）
        private MainModel m_selectedUser;
        //⑦ 右键selectedUser ->快速操作和重构 -> 使用访问器的程序块主体 （两个SelectedUser都点）
        public MainModel SelectedUser
        {
            get { return m_selectedUser; }
            set
            {
                m_selectedUser = value;

                //⑧ 添加自己写的
                OnPropertyChanged("SelectedUser");
            }
        }



        private ObservableCollection<MainModel> m_userCollection;
        public ObservableCollection<MainModel> UserCollection
        {
            get { return m_userCollection; }
            set
            {
                m_userCollection = value;

                OnPropertyChanged("UserCollection");
            }
        }


        //右键》》快速操作和重构》》封装字段（但仍使用字段）
        private MainModel m_newUserDetail;

        //右键》》快速操作和重构》》使用访问器的程序块主体
        public MainModel NewUserDetail
        {
            get { return m_newUserDetail; }
            set
            {
                m_newUserDetail = value;
                OnPropertyChanged("NewUserDetail");
            }
        }

    }
}
