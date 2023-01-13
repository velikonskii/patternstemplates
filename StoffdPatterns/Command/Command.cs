﻿namespace StoffdPatterns.Command {
    public interface ICommand {
        public abstract void Execute();
        public abstract void Undo();
    }
}