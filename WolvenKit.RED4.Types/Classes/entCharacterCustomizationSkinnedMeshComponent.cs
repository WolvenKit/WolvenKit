using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entCharacterCustomizationSkinnedMeshComponent : entSkinnedMeshComponent
	{
		[Ordinal(25)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public entCharacterCustomizationSkinnedMeshComponent()
		{
			Tags = new() { Tags = new() };
		}
	}
}
