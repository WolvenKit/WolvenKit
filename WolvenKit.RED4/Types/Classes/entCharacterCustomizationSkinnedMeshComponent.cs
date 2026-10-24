using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entCharacterCustomizationSkinnedMeshComponent : entSkinnedMeshComponent
	{
		[Ordinal(27)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public entCharacterCustomizationSkinnedMeshComponent()
		{
			Tags = new redTagList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
