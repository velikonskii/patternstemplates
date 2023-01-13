using System;
using System.Collections.Generic;

namespace StoffdPatterns.Command {
    
    public class PultInvoker {
        
        // private ICommand _command;
        private List<ICommand> _commands = new ();

        public void AddCommand(ICommand command) {
            // _command = command;
            _commands.Add(command);
        }

        public void AddCommandSet(List<ICommand> commands) {
            _commands.AddRange(commands);
        }

        public void Run() {
            foreach (var item in _commands) {
                item.Execute();
            }
        }

        public void Cancel() {
            throw new NotImplementedException();
        }

    }
}