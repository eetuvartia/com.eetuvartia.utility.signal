using System;
using System.Collections.Generic;
using Utility.Signals;

public class SignalContainer {

	private readonly Dictionary<Type, object> signals;

	public SignalContainer() {
		signals = new Dictionary<Type, object>();
	}

	private Signal<TSignalParams> GetSignal<TSignalParams>() where TSignalParams : struct, ISignalType {
		if (!signals.TryGetValue(typeof(TSignalParams), out var signal)) {
			signals.Add(typeof(TSignalParams), signal = new Signal<TSignalParams>());
		}
		return (Signal<TSignalParams>)signal;
	}

	public ISignalListener<TSignalParams> GetListener<TSignalParams>() where TSignalParams : struct, ISignalType {
		return GetSignal<TSignalParams>().Listener;
	}

	public ISignalDispatcher<TSignalParams> GetDispatcher<TSignalParams>() where TSignalParams : struct, ISignalType {
		return GetSignal<TSignalParams>().Dispatcher;
	}

}
