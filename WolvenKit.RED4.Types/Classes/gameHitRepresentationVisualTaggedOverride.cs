using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitRepresentationVisualTaggedOverride : ISerializable
	{
		private redTagList _visualTags;
		private gameHitShapeContainer _represenationOverride;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(1)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get => GetProperty(ref _represenationOverride);
			set => SetProperty(ref _represenationOverride, value);
		}
	}
}
