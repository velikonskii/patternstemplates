using System.Collections.Generic;

namespace StoffdPatterns.Command {
    public class CommandClient {
        public void Start() {
            PultInvoker pultInvoker = new PultInvoker();
            TvReceiver tvReceiver = new TvReceiver();
            pultInvoker.AddCommand(new TurnOnCommand(tvReceiver));
            
            pultInvoker.AddCommandSet(new List<ICommand> {
                new NextChannelCommand(tvReceiver),
                new NextChannelCommand(tvReceiver),
                new NextChannelCommand(tvReceiver),
                new NextChannelCommand(tvReceiver),
            });
            
            pultInvoker.Run();
        }

    }
}