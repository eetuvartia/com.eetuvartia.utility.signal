using System;
using System.Collections.Generic;

namespace com.eetuvartia.utility.signalframework.Signals {

	public class Signal<TSignalType> : ISignal<TSignalType> where TSignalType : struct, ISignalType {

		internal Signal() {
			Listener   = new SignalListener<TSignalType>(this);
			Dispatcher = new SignalDispatcher<TSignalType>(this);
		}

		public ISignalListener<TSignalType> Listener { get; }
		public ISignalDispatcher<TSignalType> Dispatcher { get; }

		private readonly HashSet<Action<TSignalType>> listeners = new HashSet<Action<TSignalType>>();

		internal void AddListener(Action<TSignalType> callback) {
			listeners.Add(callback);
		}

		internal void RemoveListener(Action<TSignalType> callback) {
			if (listeners.Contains(callback)) {
				listeners.Remove(callback);
			}
		}

		internal void Invoke(TSignalType param) {
			foreach (var listener in listeners) {
				listener(param);
			}
		}

	}

}