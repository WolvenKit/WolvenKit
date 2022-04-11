using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("cookingPlatform")] 
		public CEnum<ECookingPlatform> CookingPlatform
		{
			get => GetPropertyValue<CEnum<ECookingPlatform>>();
			set => SetPropertyValue<CEnum<ECookingPlatform>>(value);
		}
	}
}
