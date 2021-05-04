using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSignalInstance : CVariable
	{
		private CHandle<GateSignal> _gateSignal;
		private CFloat _timeStamp;
		private CArray<CName> _consumeTags;

		[Ordinal(0)] 
		[RED("gateSignal")] 
		public CHandle<GateSignal> GateSignal
		{
			get => GetProperty(ref _gateSignal);
			set => SetProperty(ref _gateSignal, value);
		}

		[Ordinal(1)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(2)] 
		[RED("consumeTags")] 
		public CArray<CName> ConsumeTags
		{
			get => GetProperty(ref _consumeTags);
			set => SetProperty(ref _consumeTags, value);
		}

		public GateSignalInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
