using System;

namespace LinkedList.Model
{
    public class Item<T>
    {     /// <summary>
          /// Хранимые данные.
          /// </summary>
        public T Data = default(T);

        /// <summary>
        /// Следующий элемент связного списка.
        /// </summary>
        public Item<T> Next { get; set; }
        /// <summary>
        /// Создание нового экземпляра связного списка.
        /// </summary>
        /// <param name="data"> Сохраняемые данные. </param>
        public Item(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data;
        }
        /// Приведение объекта к строке
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
