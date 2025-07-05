using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetPlayerMinimapIconRotationAdjustment_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("rotationAdjustment")] 
		public CFloat RotationAdjustment
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questSetPlayerMinimapIconRotationAdjustment_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
