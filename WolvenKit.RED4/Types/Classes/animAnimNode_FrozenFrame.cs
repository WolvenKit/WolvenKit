using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FrozenFrame : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("maxFramesFrozen")] 
		public CInt32 MaxFramesFrozen
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("triggerEventName")] 
		public CName TriggerEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("clearEventName")] 
		public CName ClearEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_FrozenFrame()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			MaxFramesFrozen = 5;
			TriggerEventName = "FreezeFrame";
			ClearEventName = "UnfreezeFrame";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
