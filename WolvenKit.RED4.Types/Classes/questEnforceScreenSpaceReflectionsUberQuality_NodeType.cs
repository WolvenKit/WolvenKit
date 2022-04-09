using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEnforceScreenSpaceReflectionsUberQuality_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEnforceScreenSpaceReflectionsUberQuality_NodeType()
		{
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
