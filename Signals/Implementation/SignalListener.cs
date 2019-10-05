using System;

namespace com.eetuvartia.utility.signalframework.Signals {

	internal class SignalListener<TSignalType> :
		ISignalListener<TSignalType>
		where TSignalType : struct, ISignalType {

		private readonly Signal<TSignalType> signal;

		public SignalListener(Signal<TSignalType> signal) {
			this.signal = signal;
		}

		public void Add(Action<TSignalType> callback) {
			signal.AddListener(callback);
		}

		public void Remove(Action<TSignalType> callback) {
			signal.RemoveListener(callback);
		}

	}

}