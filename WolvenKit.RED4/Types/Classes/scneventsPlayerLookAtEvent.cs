using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsPlayerLookAtEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("lookAtParams")] 
		public scneventsPlayerLookAtEventParams LookAtParams
		{
			get => GetPropertyValue<scneventsPlayerLookAtEventParams>();
			set => SetPropertyValue<scneventsPlayerLookAtEventParams>(value);
		}

		public scneventsPlayerLookAtEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Performer = new() { Id = 4294967040 };
			LookAtParams = new() { OffsetPos = new(), Duration = 0.250000F, EaseIn = true, EaseOut = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
