using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key, T>
    {
        Key[] myKey;
        Key[] tempKey;

        T[] myArray;
        T[] tempArray;


        public MyDictionary()
        {
            myKey = new Key[0];
            myArray = new T[0];
        }

        public void Add(Key keyItem, T TItem)
        {
            tempKey = myKey;
            tempArray = myArray;

            myKey = new Key[myKey.Length + 1];
            myArray = new T[myArray.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                myKey[i] = tempKey[i];
            }
            myKey[myKey.Length - 1] = keyItem;

            for (int i = 0; i < tempArray.Length; i++)
            {
                myArray[i] = tempArray[i];
            }


            myArray[myArray.Length - 1] = TItem;

        }
        public Key[] KeyValue { get { return myKey; } }

        public T[] ItemValue { get { return myArray; } }


    }
}
