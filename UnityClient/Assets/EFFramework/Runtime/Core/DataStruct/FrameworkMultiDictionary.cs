using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EFFramework
{
    /// <summary>
    /// 应用框架多值字典类。
    /// </summary>
    /// <typeparam name="TKey">指定多值字典的主键类型。</typeparam>
    /// <typeparam name="TValue">指定多值字典的值类型。</typeparam>
    public sealed class FrameworkMultiDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, FrameworkLinkedListRange<TValue>>>, IEnumerable
    {
        private readonly FrameworkLinkedList<TValue> _linkedList;
        private readonly Dictionary<TKey, FrameworkLinkedListRange<TValue>> _dictionary;

        /// <summary>
        /// 初始化应用框架多值字典类的新实例。
        /// </summary>
        public FrameworkMultiDictionary()
        {
            _linkedList = new FrameworkLinkedList<TValue>();
            _dictionary = new Dictionary<TKey, FrameworkLinkedListRange<TValue>>();
        }

        /// <summary>
        /// 获取多值字典中实际包含的主键数量。
        /// </summary>
        public int Count => _dictionary.Count;

        /// <summary>
        /// 获取多值字典中指定主键的范围。
        /// </summary>
        /// <param name="key">指定的主键。</param>
        /// <returns>指定主键的范围。</returns>
        public FrameworkLinkedListRange<TValue> this[TKey key]
        {
            get
            {
                FrameworkLinkedListRange<TValue> range = default(FrameworkLinkedListRange<TValue>);
                _dictionary.TryGetValue(key, out range);
                return range;
            }
        }

        /// <summary>
        /// 清理多值字典。
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
            _linkedList.Clear();
        }

        /// <summary>
        /// 检查多值字典中是否包含指定主键。
        /// </summary>
        /// <param name="key">要检查的主键。</param>
        /// <returns>多值字典中是否包含指定主键。</returns>
        public bool Contains(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        /// <summary>
        /// 检查多值字典中是否包含指定值。
        /// </summary>
        /// <param name="key">要检查的主键。</param>
        /// <param name="value">要检查的值。</param>
        /// <returns>多值字典中是否包含指定值。</returns>
        public bool Contains(TKey key, TValue value)
        {
            FrameworkLinkedListRange<TValue> range = default(FrameworkLinkedListRange<TValue>);
            if (_dictionary.TryGetValue(key, out range))
            {
                return range.Contains(value);
            }

            return false;
        }

        /// <summary>
        /// 尝试获取多值字典中指定主键的范围。
        /// </summary>
        /// <param name="key">指定的主键。</param>
        /// <param name="range">指定主键的范围。</param>
        /// <returns>是否获取成功。</returns>
        public bool TryGetValue(TKey key, out FrameworkLinkedListRange<TValue> range)
        {
            return _dictionary.TryGetValue(key, out range);
        }

        /// <summary>
        /// 向指定的主键增加指定的值。
        /// </summary>
        /// <param name="key">指定的主键。</param>
        /// <param name="value">指定的值。</param>
        public void Add(TKey key, TValue value)
        {
            FrameworkLinkedListRange<TValue> range = default(FrameworkLinkedListRange<TValue>);
            if (_dictionary.TryGetValue(key, out range))
            {
                _linkedList.AddBefore(range.Terminal, value);
            }
            else
            {
                LinkedListNode<TValue> first = _linkedList.AddLast(value);
                LinkedListNode<TValue> terminal = _linkedList.AddLast(default(TValue));
                _dictionary.Add(key, new FrameworkLinkedListRange<TValue>(first, terminal));
            }
        }

        /// <summary>
        /// 从指定的主键中移除指定的值。
        /// </summary>
        /// <param name="key">指定的主键。</param>
        /// <param name="value">指定的值。</param>
        /// <returns>是否移除成功。</returns>
        public bool Remove(TKey key, TValue value)
        {
            FrameworkLinkedListRange<TValue> range = default(FrameworkLinkedListRange<TValue>);
            if (_dictionary.TryGetValue(key, out range))
            {
                for (LinkedListNode<TValue> current = range.First; current != null && current != range.Terminal; current = current.Next)
                {
                    if (current.Value.Equals(value))
                    {
                        if (current == range.First)
                        {
                            LinkedListNode<TValue> next = current.Next;
                            if (next == range.Terminal)
                            {
                                _linkedList.Remove(next);
                                _dictionary.Remove(key);
                            }
                            else
                            {
                                _dictionary[key] = new FrameworkLinkedListRange<TValue>(next, range.Terminal);
                            }
                        }

                        _linkedList.Remove(current);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 从指定的主键中移除所有的值。
        /// </summary>
        /// <param name="key">指定的主键。</param>
        /// <returns>是否移除成功。</returns>
        public bool RemoveAll(TKey key)
        {
            FrameworkLinkedListRange<TValue> range = default(FrameworkLinkedListRange<TValue>);
            if (_dictionary.TryGetValue(key, out range))
            {
                _dictionary.Remove(key);

                LinkedListNode<TValue> current = range.First;
                while (current != null)
                {
                    LinkedListNode<TValue> next = current != range.Terminal ? current.Next : null;
                    _linkedList.Remove(current);
                    current = next;
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// 返回循环访问集合的枚举数。
        /// </summary>
        /// <returns>循环访问集合的枚举数。</returns>
        public Enumerator GetEnumerator()
        {
            return new Enumerator(_dictionary);
        }

        /// <summary>
        /// 返回循环访问集合的枚举数。
        /// </summary>
        /// <returns>循环访问集合的枚举数。</returns>
        IEnumerator<KeyValuePair<TKey, FrameworkLinkedListRange<TValue>>> IEnumerable<KeyValuePair<TKey, FrameworkLinkedListRange<TValue>>>.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// 返回循环访问集合的枚举数。
        /// </summary>
        /// <returns>循环访问集合的枚举数。</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// 循环访问集合的枚举数。
        /// </summary>
        [StructLayout(LayoutKind.Auto)]
        public struct Enumerator : IEnumerator<KeyValuePair<TKey, FrameworkLinkedListRange<TValue>>>, IEnumerator
        {
            private Dictionary<TKey, FrameworkLinkedListRange<TValue>>.Enumerator m_Enumerator;

            internal Enumerator(Dictionary<TKey, FrameworkLinkedListRange<TValue>> dictionary)
            {
                if (dictionary == null)
                {
                    throw new FrameworkException("Dictionary is invalid.");
                }

                m_Enumerator = dictionary.GetEnumerator();
            }

            /// <summary>
            /// 获取当前结点。
            /// </summary>
            public KeyValuePair<TKey, FrameworkLinkedListRange<TValue>> Current => m_Enumerator.Current;

            /// <summary>
            /// 获取当前的枚举数。
            /// </summary>
            object IEnumerator.Current => m_Enumerator.Current;

            /// <summary>
            /// 清理枚举数。
            /// </summary>
            public void Dispose()
            {
                m_Enumerator.Dispose();
            }

            /// <summary>
            /// 获取下一个结点。
            /// </summary>
            /// <returns>返回下一个结点。</returns>
            public bool MoveNext()
            {
                return m_Enumerator.MoveNext();
            }

            /// <summary>
            /// 重置枚举数。
            /// </summary>
            void IEnumerator.Reset()
            {
                ((IEnumerator<KeyValuePair<TKey, FrameworkLinkedListRange<TValue>>>)m_Enumerator).Reset();
            }
        }
    }
}
