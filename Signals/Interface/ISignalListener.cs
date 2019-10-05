using System;

namespace com.eetuvartia.utility.signalframework.Signals {

	public interface ISignalListener<TSignalType>
		where TSignalType : struct, ISignalType {

		void Add(Action<TSignalType> callback);
		void Remove(Action<TSignalType> callback);

	}

}
