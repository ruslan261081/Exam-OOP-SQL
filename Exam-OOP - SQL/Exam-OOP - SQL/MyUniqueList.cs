using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP___SQL
{
    class MyUniqueList
    {
        List<int> list = new List<int>();



        public MyUniqueList()

        {



        }



        public bool Add(int item)

        {

            if (!list.Contains(item))

            {

                list.Add(item);

                return true;
                throw new IndexOutOfRangeException();
            }



            return false;

        }



        public bool Remove(int item)

        {

            if (list.Contains(item))

            {

                list.Remove(item);

                return true;
                throw new ItemAlreadyExistException();
            }



            return false;

        }



        public int Peek(int index)

        {

            return list[index];
            throw new ItemNotFoundException();

        }



        public int this[int index]

        {

            get

            {

                return this.list[index];

            }

            set

            {

                if (list[index] == value)

                    return;

                if (list.Contains(value))

                    return;

                list[index] = value;

            }

        }
    }
}
