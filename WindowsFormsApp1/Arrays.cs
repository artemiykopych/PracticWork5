using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Arrays {
        public bool error = false;
        int[] a;
        int length = 8;

        public int Length {
            get { return length; }
            set { length = value; }
        }

        public int this[int i] {
            get {
                if (0 <= i && i < length) {
                    return a[i];
                }
                else {
                    error = true;
                    return 0;
                }
            }
            set {
                if (0 <= i && i < length && value >= -100 && value <= 100) {
                    a[i] = value;
                }
                else {
                    error = true;
                }
            }
        }

        public Arrays() {
            a = new int[length];
        }

        public Arrays(int[] mas) {
            a = mas;
        }

        public Arrays(int size) {
            Length = size;
            a = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++) {
                a[i] = rand.Next(-10, 10);
            }
        }

        public int MinCount {
            get {
                int k = 0;

                foreach (int i in a) {
                    if (i < 0) {
                        k += 1;
                    }
                }

                return k;
            }
        }

    }
}
