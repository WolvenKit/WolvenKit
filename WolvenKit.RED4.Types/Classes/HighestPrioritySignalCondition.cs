using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighestPrioritySignalCondition : AIbehaviorexpressionScript
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
	}
}
