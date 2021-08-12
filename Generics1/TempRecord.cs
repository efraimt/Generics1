using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics1
{

    public class TempMessured
    {
        public DateOnly Date { get; set; }
        public float CelciusDegree { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public int Height { get; set; }

        public string Name { get; set; }
    }

    public class StudentsManagament
    {
        public int Count { get; set; }
        Student[] Students { get; set; } = new Student[100];

        public void Add(Student student)
        {
            Students[Count] = student;
            Count++;
        }

        public Student LastStudent
        { 
            get => Students[Count - 1];
            set => Students[Count - 1] = value;
        }

        public Student GetByIndex(int index)
        {
            return Students[index];
        }


        public Student GetById(int id)
        {
            foreach (var item in Students)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public Student GetByName(string name)
        {
            foreach (var item in Students)
            {
                if(item.Name==name)
                return item;
            }
            return null;
}


        public Student this [int i] => Students[i];
        public Student this [string name]=>GetByName(name);
    }
}

public class TempRecord
{
    // Array of temperature values
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    // To enable client code to validate input
    // when accessing your indexer.
    public int Length => temps.Length;

    // Indexer declaration.
    // If index is out of range, the temps array will throw the exception.
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }

    public int MyProperty { get; set; }
}
}
