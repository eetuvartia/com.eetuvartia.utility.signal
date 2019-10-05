namespace com.eetuvartia.utility.signalframework.Signals {

	public interface ISignalDispatcher<TSignalType>
		where TSignalType : struct, ISignalType {

		void Invoke(TSignalType param);

	}

}
