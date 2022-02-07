using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SampleProgram.Class;

namespace SampleProgram.Controls.ViewModel
{
    public class DataGridControlViewModel : PropertyChangeBase
    {
        private ObservableCollection <UserInfo> _userList;
        public ObservableCollection<UserInfo> UserList
        {
            get => _userList;
            set
            {
                _userList = value;
                onPropertyChanged();
            }
        }

        public DataGridControlViewModel()
        {
            UserInfo user1 = new UserInfo() {
                Seq = 190301,
                Name = "김철수",
                Email = "cskim@work.com",
                Team = "H/W",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 03, 02),
                LeaveDate = null
            };
            UserList.Add(user1);


            UserInfo user2 = new UserInfo()
            {
                Seq = 190302,
                Name = "김영희",
                Email = "yhkim@work.com",
                Team = "경영지원",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 03, 02),
                LeaveDate = null
            };
            UserList.Add(user2);

            UserInfo user3 = new UserInfo()
            {
                Seq = 190303,
                Name = "박지민",
                Email = "jimin.p@work.com",
                Team = "S/W",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 03, 06),
                LeaveDate = null
            };
            UserList.Add(user3);

            UserInfo user4 = new UserInfo()
            {
                Seq = 190304,
                Name = "박민수",
                Email = "min@work.com",
                Team = "H/W",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 03, 10),
                LeaveDate = null
            };
            UserList.Add(user4);

            UserInfo user5 = new UserInfo()
            {
                Seq = 190305,
                Name = "이영수",
                Email = "soo.lee@work.com",
                Team = "S/W",
                IsIncumbent = false,
                JoinDate = new DateTime(2019, 03, 02),
                LeaveDate = new DateTime(2019, 10, 30)
            };
            UserList.Add(user5);

            UserInfo user6 = new UserInfo()
            {
                Seq = 190306,
                Name = "이수정",
                Email = "cristal@work.com",
                Team = "S/W",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 04, 01),
                LeaveDate = null
            };
            UserList.Add(user6);

            UserInfo user7 = new UserInfo()
            {
                Seq = 190307,
                Name = "정민수",
                Email = "min.jung@work.com",
                Team = "마케팅",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 04, 01),
                LeaveDate = null
            };
            UserList.Add(user7);

            UserInfo user8 = new UserInfo()
            {
                Seq = 190308,
                Name = "최철수",
                Email = "cschoi@work.com",
                Team = "H/W",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 04, 09),
                LeaveDate = null
            };
            UserList.Add(user8);

            UserInfo user9 = new UserInfo()
            {
                Seq = 190309,
                Name = "정미영",
                Email = "mi0.jung@work.com",
                Team = "디자인",
                IsIncumbent = true,
                JoinDate = new DateTime(2019, 04, 20),
                LeaveDate = null
            };
            UserList.Add(user9);

            UserInfo user10 = new UserInfo()
            {
                Seq = 190310,
                Name = "김희진",
                Email = "jin.k@work.com",
                Team = "경영지원",
                IsIncumbent = false,
                JoinDate = new DateTime(2019, 05, 02),
                LeaveDate = new DateTime(2020, 09, 19)
            };
            UserList.Add(user10);

        }
    }
}
