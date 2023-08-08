using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Database
    {
        private static List<Categories> _categories;
        private static List<Users> _users;
        static Database()
        {
            _categories = new()
        {
            new Categories{categoryID=1,categoryName="Sports",categoryVote=1},
            new Categories{categoryID=2,categoryName="Movies",categoryVote=3},
            new Categories{categoryID=3,categoryName="Animals",categoryVote=5},
            new Categories{categoryID=4,categoryName="Technology",categoryVote=2},
            new Categories{categoryID=5,categoryName="Geography",categoryVote=1},
        };

            _users = new()
        {
            new Users{userName="cptmfs",isVoted=false},
            new Users{userName="seysimsek",isVoted=false},
            new Users{userName="ucartahir",isVoted=false},
        };
        }
        public static List<Categories> categories => _categories;
        public static List<Users> users => _users;
    }

}
