using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStackSignalConditionData : RedBaseClass
	{
		private CUInt32 _callbackId;
		private CBool _lastValue;

		[Ordinal(0)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetProperty(ref _callbackId);
			set => SetProperty(ref _callbackId, value);
		}

		[Ordinal(1)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get => GetProperty(ref _lastValue);
			set => SetProperty(ref _lastValue, value);
		}
	}
}
