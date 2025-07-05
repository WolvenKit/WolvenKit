using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCountdownTimer_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questCountdownTimer_NodeType()
		{
			Duration = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
