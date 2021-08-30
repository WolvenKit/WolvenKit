using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FrozenFrame : animAnimNode_OnePoseInput
	{
		private CInt32 _maxFramesFrozen;
		private CName _triggerEventName;
		private CName _clearEventName;

		[Ordinal(12)] 
		[RED("maxFramesFrozen")] 
		public CInt32 MaxFramesFrozen
		{
			get => GetProperty(ref _maxFramesFrozen);
			set => SetProperty(ref _maxFramesFrozen, value);
		}

		[Ordinal(13)] 
		[RED("triggerEventName")] 
		public CName TriggerEventName
		{
			get => GetProperty(ref _triggerEventName);
			set => SetProperty(ref _triggerEventName, value);
		}

		[Ordinal(14)] 
		[RED("clearEventName")] 
		public CName ClearEventName
		{
			get => GetProperty(ref _clearEventName);
			set => SetProperty(ref _clearEventName, value);
		}

		public animAnimNode_FrozenFrame()
		{
			_maxFramesFrozen = 5;
			_triggerEventName = "FreezeFrame";
			_clearEventName = "UnfreezeFrame";
		}
	}
}
