using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutlineRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get => GetPropertyValue<CHandle<OutlineRequest>>();
			set => SetPropertyValue<CHandle<OutlineRequest>>(value);
		}

		[Ordinal(1)] 
		[RED("flag")] 
		public CBool Flag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("outlineDuration")] 
		public CFloat OutlineDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OutlineRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
