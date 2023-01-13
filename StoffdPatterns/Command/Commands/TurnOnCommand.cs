namespace StoffdPatterns.Command {
    public class TurnOnCommand : ICommand {
        
        private TvReceiver _tvReceiver;

        public TurnOnCommand(TvReceiver tvReceiver) {
            _tvReceiver = tvReceiver;
        }

        public void Execute() {
            _tvReceiver.On();
        }

        public void Undo() {
            throw new System.NotImplementedException();
        }
    }
}