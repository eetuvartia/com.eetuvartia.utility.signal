namespace com.eetuvartia.utility.signalframework.Signals {

	internal class SignalDispatcher<TSignalType> :
		ISignalDispatcher<TSignalType>
		where TSignalType : struct, ISignalType {

		private readonly Signal<TSignalType> signal;

		public SignalDispatcher(Signal<TSignalType> signal) {
			this.signal = signal;
		}

		public void Invoke(TSignalType param) {
			signal.Invoke(param);
		}

	}

}
