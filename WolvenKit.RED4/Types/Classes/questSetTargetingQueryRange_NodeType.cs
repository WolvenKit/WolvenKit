using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTargetingQueryRange_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("targetingQueryRange")] 
		public CFloat TargetingQueryRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetTargetingQueryRange_NodeType()
		{
			TargetingQueryRange = 50.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
