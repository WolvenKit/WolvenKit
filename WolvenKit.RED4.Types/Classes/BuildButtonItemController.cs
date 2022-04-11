using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuildButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] 
		[RED("associatedBuild")] 
		public CEnum<gamedataBuildType> AssociatedBuild
		{
			get => GetPropertyValue<CEnum<gamedataBuildType>>();
			set => SetPropertyValue<CEnum<gamedataBuildType>>(value);
		}
	}
}
