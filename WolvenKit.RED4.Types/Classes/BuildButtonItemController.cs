using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuildButtonItemController : inkButtonDpadSupportedController
	{
		private CEnum<gamedataBuildType> _associatedBuild;

		[Ordinal(26)] 
		[RED("associatedBuild")] 
		public CEnum<gamedataBuildType> AssociatedBuild
		{
			get => GetProperty(ref _associatedBuild);
			set => SetProperty(ref _associatedBuild, value);
		}
	}
}
