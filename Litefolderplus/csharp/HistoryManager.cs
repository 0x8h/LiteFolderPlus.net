using System;
using System.Collections.Generic;
using System.IO;

namespace Litefolderplus.csharp
{
    internal class HistoryManager
    {
        private static string _current = "Home";
        private static Stack<string> _backstack;
        private static List<string> _forwordList;
        public static event Action<string> PathChanged;

        internal HistoryManager()
        {
            _current = "Home";
            _backstack = new Stack<string>();
            _forwordList = new List<string>();
        }
        internal static void MoveTo(string path)
        {
            if (_backstack == null)
            {
                _backstack = new Stack<string>();
            }

            if (_forwordList == null)
            {
                _forwordList = new List<string>();
            }
            if (path == _current)
            {
                return;
            }
            _backstack.Push(_current);
            _forwordList.Clear();

            _current = path;
            PathChanged?.Invoke(_current);
        }

        internal static string Back()
        {
            if (_backstack.Count > 0)
            {
                _forwordList.Add(_current);
                _current = _backstack.Pop();
                PathChanged?.Invoke(_current);
            }
            return _current;
        }

        internal static string Forward()
        {
            if (_forwordList.Count > 0)
            {
                _backstack.Push(_current);
                _current = _forwordList[_forwordList.Count - 1];
                _forwordList.RemoveAt(_forwordList.Count - 1);
                
                PathChanged?.Invoke(_current);
            }

            return _current;
        }

        internal static string GetCurrentDir()
        {
            return _current;
        }
    }
}