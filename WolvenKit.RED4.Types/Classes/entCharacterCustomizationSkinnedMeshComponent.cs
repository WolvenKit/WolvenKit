using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entCharacterCustomizationSkinnedMeshComponent : entSkinnedMeshComponent
	{
		private redTagList _tags;

		[Ordinal(25)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}
	}
}
