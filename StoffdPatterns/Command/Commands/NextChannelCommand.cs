namespace StoffdPatterns.Command {
    public class NextChannelCommand : ICommand {
        
        private TvReceiver _tvReceiver;

        public NextChannelCommand(TvReceiver tvReceiver) {
            _tvReceiver = tvReceiver;
        }

        public void Execute() {
            _tvReceiver.NextChannel();
        }

        public void Undo() {
            throw new System.NotImplementedException();
        }
        
    }
}