using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInstancedCrowdControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("crowdVariantTag")] 
		public CName CrowdVariantTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questInstancedCrowdControlNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
