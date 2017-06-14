using System;
using System.Collections.Generic;

namespace Day1
{
    public class Walker
    {
        private int posX;
        private int posY;
        private char direction = 'N';

        private List<string[]> coordinateList = new List<string[]>();

        public void walk(string[] route)
        {
            foreach (string element in route)
            {
                leftOrRight(element[0]);
                forward(Int32.Parse(element.Substring(1)));
            }
        }

        private void leftOrRight(char input)
        {
            if (input == 'L')
            {
                left();
            }
            else
            {
                right();
            }
        }

        private void left()
        {
            switch (getDirection())
            {
                case ('N'):
                    setDirection('W');
                    break;

                case ('E'):
                    setDirection('N');
                    break;

                case ('S'):
                    setDirection('E');
                    break;

                case ('W'):
                    setDirection('S');
                    break;
            }
        }

        private void right()
        {
            switch (getDirection())
            {
                case ('N'):
                    setDirection('E');
                    break;

                case ('E'):
                    setDirection('S');
                    break;

                case ('S'):
                    setDirection('W');
                    break;

                case ('W'):
                    setDirection('N');
                    break;
            }
        }

        private void forward(int distance)
        {
            forward(distance, 0);
        }

        private void forward(int distance, int counter)
        {
            if (counter == distance) return;

            switch (this.direction)
            {
                case 'N':
                    posY++;
                    break;

                case 'E':
                    posX++;
                    break;

                case 'S':
                    posY--;
                    break;

                case 'W':
                    posX--;
                    break;
            }

            forward(distance, counter + 1);
        }

        public void reset()
        {
            direction = 'N';
            posX = 0;
            posY = 0;
        }

        public char getDirection()
        {
            return this.direction;
        }

        public int getDistance()
        {
            return Math.Abs(posX) + Math.Abs(posY);
        }

        public int getPosY(int newPosY)
        {
            return this.posY;
        }

        public int getposX(int newPosX)
        {
            return this.posX;
        }

        public void setDirection(char newDirection)
        {
            if (newDirection != 'N' && newDirection != 'E' && newDirection != 'W' && newDirection != 'S')
            {
                throw new InvalidOperationException();
            }
            this.direction = newDirection;
        }
    }
}