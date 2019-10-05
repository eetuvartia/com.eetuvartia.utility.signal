using System;

namespace Utility.Signals {

	public interface ISignalListener<TSignalType>
		where TSignalType : struct, ISignalType {

		void Add(Action<TSignalType> callback);
		void Remove(Action<TSignalType> callback);

	}

}
