using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuildButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(29)] 
		[RED("associatedBuild")] 
		public CEnum<gamedataBuildType> AssociatedBuild
		{
			get => GetPropertyValue<CEnum<gamedataBuildType>>();
			set => SetPropertyValue<CEnum<gamedataBuildType>>(value);
		}

		public BuildButtonItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
