﻿using System;

namespace Microsoft.Automata
{
    /// <summary>
    /// Represents a move of a symbolic finite automaton.
    /// The value default(L) is reserved to represent the label of an epsilon move.
    /// Thus if S is a reference type the label of an epsilon move is null.
    /// </summary>
    /// <typeparam name="L">the type of the labels on moves</typeparam>
    public class Move<L>
    {
        /// <summary>
        /// Source state of the move
        /// </summary>
        public readonly int SourceState;
        /// <summary>
        /// Target state of the move
        /// </summary>
        public readonly int TargetState;
        /// <summary>
        /// Label of the move
        /// </summary>
        public readonly L Label;

        /// <summary>
        /// Transition of an automaton.
        /// </summary>
        /// <param name="sourceState">source state of the transition</param>
        /// <param name="targetState">target state of the transition</param>
        /// <param name="lab">label of the transition</param>
        public Move(int sourceState, int targetState, L lab)
        {
            this.SourceState = sourceState;
            this.TargetState = targetState;
            this.Label = lab;
        } 

        /// <summary>
        /// Creates a move. Creates an epsilon move if label is default(L).
        /// </summary>
        public static Move<L> Create(int sourceState, int targetState, L condition)
        {
            return new Move<L>(sourceState, targetState, condition);
        }

        /// <summary>
        /// Creates an epsilon move. Same as Create(sourceState, targetState, default(L)).
        /// </summary>
        public static Move<L> Epsilon(int sourceState, int targetState)
        {
            return new Move<L>(sourceState, targetState, default(L));
        }

        /// <summary>
        /// Returns true if label equals default(S).
        /// </summary>
        public bool IsEpsilon
        {
            get
            {
                return object.Equals(Label, default(L));
            }
        }

        /// <summary>
        /// Returns true if obj is a move with the same source state, target state, and label.
        /// </summary>
        public override bool Equals(object obj)
        {

            if (!(obj is Move<L>))
                return false;
            Move<L> t = (Move<L>)obj;
            return (t.SourceState == SourceState && t.TargetState == TargetState &&
                (object.Equals(t.Label, default(L)) ? object.Equals(Label, default(L))
                : t.Label.Equals(Label)));
        }

        public override int GetHashCode()
        {
            return SourceState + (TargetState * 2) + (object.Equals(Label, default(L)) ? 0 : Label.GetHashCode());
        }

        public override string ToString()
        {
            return "(" + SourceState + "," + (object.Equals(Label, default(L)) ? "" : Label + ",") + TargetState + ")";
        }
    }
}
