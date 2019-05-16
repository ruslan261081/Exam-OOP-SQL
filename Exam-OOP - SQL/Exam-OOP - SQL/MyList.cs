using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP___SQL
{
    class MyList<T> where T : new()
    {
        List<T> list = new List<T>();



        public MyList()

        {



        }



        public bool Add(T item)

        {

            if (!list.Contains(item))

            {

                list.Add(item);

                return true;

            }



            return false;

        }



        public bool Remove(T item)

        {

            if (list.Contains(item))

            {

                list.Remove(item);

                return true;

            }



            return false;

        }



        public int Peek(T index)

        {

            return  list [];

        }



        public T this[int index]

        {

            get

            {

                return this.list[index];

            }

            set

            {

                if (list[index].Equals(value))

                    return;

                if (list.Contains(value))

                    return;

                list[index] = value;

            }

        }
    }
}
