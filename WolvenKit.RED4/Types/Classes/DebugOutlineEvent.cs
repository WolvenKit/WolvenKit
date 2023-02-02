using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugOutlineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<EOutlineType> Type
		{
			get => GetPropertyValue<CEnum<EOutlineType>>();
			set => SetPropertyValue<CEnum<EOutlineType>>(value);
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DebugOutlineEvent()
		{
			Requester = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
