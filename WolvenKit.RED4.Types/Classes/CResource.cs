using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CResource : ISerializable
	{
		private CEnum<ECookingPlatform> _cookingPlatform;

		[Ordinal(0)] 
		[RED("cookingPlatform")] 
		public CEnum<ECookingPlatform> CookingPlatform
		{
			get => GetProperty(ref _cookingPlatform);
			set => SetProperty(ref _cookingPlatform, value);
		}
	}
}
