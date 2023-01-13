using System;

namespace StoffdPatterns.Command {
    public class TvReceiver {

        private int _currentChannel = 1;
        
        public void On() {
            Console.WriteLine("Turned On");
        }
        
        public void NextChannel() {
            _currentChannel++;
            Console.WriteLine($"Channel: {_currentChannel}");
        }
        
        public void PreviousChannel() {
            _currentChannel--;
            Console.WriteLine($"Channel: {_currentChannel}");
        }
        
        public void Off() {
            Console.WriteLine("Turned Off");
        }

    }
}