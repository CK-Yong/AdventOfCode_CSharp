using System;
using System.Collections.Generic;

namespace Day1
{
    public class Walker
    {
        private List<string[]> _coordinateList = new List<string[]>();
        private char _direction = 'N';
        private int _posX;
        private int _posY;

        public void Walk(string[] route)
        {
            foreach (var element in route)
            {
                LeftOrRight(element[0]);
                Forward(int.Parse(element.Substring(1)));
            }
        }

        private void LeftOrRight(char input)
        {
            if (input == 'L')
                Left();
            else
                Right();
        }

        private void Left()
        {
            switch (GetDirection())
            {
                case 'N':
                    SetDirection('W');
                    break;

                case 'E':
                    SetDirection('N');
                    break;

                case 'S':
                    SetDirection('E');
                    break;

                case 'W':
                    SetDirection('S');
                    break;
            }
        }

        private void Right()
        {
            switch (GetDirection())
            {
                case 'N':
                    SetDirection('E');
                    break;

                case 'E':
                    SetDirection('S');
                    break;

                case 'S':
                    SetDirection('W');
                    break;

                case 'W':
                    SetDirection('N');
                    break;
            }
        }

        private void Forward(int distance, int counter = 0)
        {
            if (counter == distance) return;

            switch (_direction)
            {
                case 'N':
                    _posY++;
                    break;

                case 'E':
                    _posX++;
                    break;

                case 'S':
                    _posY--;
                    break;

                case 'W':
                    _posX--;
                    break;
            }

            Forward(distance, counter + 1);
        }

        public void Reset()
        {
            _direction = 'N';
            _posX = 0;
            _posY = 0;
        }

        public char GetDirection()
        {
            return _direction;
        }

        public int GetDistance()
        {
            return Math.Abs(_posX) + Math.Abs(_posY);
        }

        public int GetPosY(int newPosY)
        {
            return _posY;
        }

        public int GetposX(int newPosX)
        {
            return _posX;
        }

        public void SetDirection(char newDirection)
        {
            if (newDirection != 'N' && newDirection != 'E' && newDirection != 'W' && newDirection != 'S')
                throw new InvalidOperationException();
            _direction = newDirection;
        }
    }
}