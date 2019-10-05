namespace com.eetuvartia.utility.signalframework.Signals {

	public interface ISignal<TSignalType>
		where TSignalType : struct, ISignalType {

		ISignalListener<TSignalType> Listener { get; }
		ISignalDispatcher<TSignalType> Dispatcher { get; }

	}

}
