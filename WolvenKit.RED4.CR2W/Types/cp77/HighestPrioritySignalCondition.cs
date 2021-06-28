using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighestPrioritySignalCondition : AIbehaviorexpressionScript
	{
		private CName _signalName;
		private CUInt32 _cbId;
		private CBool _lastValue;

		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(1)] 
		[RED("cbId")] 
		public CUInt32 CbId
		{
			get => GetProperty(ref _cbId);
			set => SetProperty(ref _cbId, value);
		}

		[Ordinal(2)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get => GetProperty(ref _lastValue);
			set => SetProperty(ref _lastValue, value);
		}

		public HighestPrioritySignalCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
