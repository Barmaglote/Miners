using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{

    public static class Mines
    {

        public static Boolean IsFinished {
            get {
                return _IsFinished;
            }
            set {
                _IsFinished = value;
            }
        }

        // В начале считаем, что поиск бомб завершен
        private static Boolean _IsFinished = true;

        public static Boolean IsBombed
        {
            get {
                return _IsBombed; 
            }
            set {
                _IsBombed = value;
                if (_IsBombed) OnFail(0);
            }
        }

        private static Boolean _IsBombed = false;

        public delegate void MarkedIsUpdated(int mark);

        /// <summary>
        /// Событие для обновления счетчика найденных бомб
        /// </summary>
        public static event MarkedIsUpdated OnMarked;
        public static event MarkedIsUpdated OnVictory;
        public static event MarkedIsUpdated OnFail;

        public static int? Count
        {
            get
            {
                if (_Count == null)
                {
                    _Count = Boxes.Values.Where(x => x.IsBomb).ToList<Mine>().Count;
                }

                return _Count;
            }
        }

        private static int? _Count = null;

        public static int Marked
        {
            get
            {
                return _Marked;
            }
            set
            {
                _Marked = value;
                OnMarked(value);
                CheckVictoryState();
            }
        }

        private static int _Marked = 0;

        public static void CheckVictoryState()
        {

            if (Count == null) return;

            if (Marked == Count)
            {
                List<Mine> bombs = Boxes.Values.Where(x => x.IsBomb).ToList<Mine>();
                List<Mine> marks = Boxes.Values.Where(x => x.IsMarked).ToList<Mine>();
                List<Mine> opened = Boxes.Values.Where(x => x.IsOpened).ToList<Mine>();

                if (bombs.Where(b => marks.Any(m => m.A == b.A && m.B == b.B)).ToList<Mine>().Count == Marked && Boxes.Count == (marks.Count + opened.Count))
                {
                    IsFinished = true;
                    OnVictory(0);
                }

            }
        }

        //public static List<Mine> Buttons = new List<Mine>();
        public static Dictionary<Coords, Mine> Boxes = new Dictionary<Coords, Mine>();

        // число элементов по оси X
        public static int X;
        // число элементов по оси Y
        public static int Y;

        public static void Init(Dictionary<Coords, Mine> boxes, int x, int y)
        {
            Mines.Boxes = boxes;
            Mines.X = x;
            Mines.Y = y;
        }

        public static int GetBombsCount(int a, int b)
        {
            return GetNeiboughers(a, b).Where(m => m.IsBomb).Count();
        }

        public static List<Mine> GetNeiboughers(int a, int b)
        {

            List<Mine> neiboughers = new List<Mine>();
            try
            {
                // 1,1
                if ((a > 0) && (b > 0))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a - 1, b - 1)]);
                }

                // 2,1
                if ((b > 0))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a, b - 1)]);
                }

                // 3,1
                if ((b > 0) && (a < X - 1))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a + 1, b - 1)]);
                }

                // 1,2
                if (a > 0)
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a - 1, b)]);
                }

                // 3,2
                if ((a < X - 1))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a + 1, b)]);
                }

                // 1,3
                if ((a > 0) && (b < Y - 1))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a - 1, b + 1)]);
                }

                // 2,3
                if (b < Y - 1)
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a, b + 1)]);
                }

                // 3,3
                if ((a < X - 1) && (b < Y - 1))
                {
                    neiboughers.Add(Mines.Boxes[new Coords(a + 1, b + 1)]);
                }
            }
            catch { }
            return neiboughers;
        }

        public static void OpenAll()
        {
            foreach (Mine mine in Mines.Boxes.Values)
            {
                mine.Open();
            }

            CheckVictoryState();
        }
    }

}
