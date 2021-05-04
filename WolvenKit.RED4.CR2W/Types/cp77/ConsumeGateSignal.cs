using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConsumeGateSignal : GateSignal
	{
		private CName _consumeCallName;
		private CHandle<GateSignal> _signalToConsume;

		[Ordinal(4)] 
		[RED("consumeCallName")] 
		public CName ConsumeCallName
		{
			get => GetProperty(ref _consumeCallName);
			set => SetProperty(ref _consumeCallName, value);
		}

		[Ordinal(5)] 
		[RED("signalToConsume")] 
		public CHandle<GateSignal> SignalToConsume
		{
			get => GetProperty(ref _signalToConsume);
			set => SetProperty(ref _signalToConsume, value);
		}

		public ConsumeGateSignal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
