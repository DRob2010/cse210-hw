using System;

public class Breathing : Activities
{
    private bool _duringActivity;
    private bool _breatheIn;
    private bool _breatheOut;
    private int _intime;
    private int _outTime;
    private int returnTime;

    public Breathing()
    {
        
    }

    public void DuringBreathingActivity(int time)
    {
        _duringActivity = true;
        while (_duringActivity)
        {
            _intime = 5;
            _breatheIn = true;
            while (_breatheIn)
            {
                Console.Clear();
                Console.WriteLine("Breathe in..." + _intime);
                Thread.Sleep(1000);
                _intime -= 1;
                if (_intime < 0)
                {
                    _breatheIn = false;
                }
            }
            _outTime = 5;
            _breatheOut = true;
            while (_breatheOut)
            {
                Console.Clear();
                Console.WriteLine("Breathe out..." + _outTime);
                Thread.Sleep(1000);
                _outTime -= 1;
                if (_outTime < 0)
                {
                    _breatheOut = false;
                }
            }
            time -= 10;
            returnTime += 10;
            if (time < 0) 
            {
                _duringActivity = false;
            }
        }
    }
}