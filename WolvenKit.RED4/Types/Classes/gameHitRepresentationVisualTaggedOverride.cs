using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitRepresentationVisualTaggedOverride : ISerializable
	{
		[Ordinal(0)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(1)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get => GetPropertyValue<gameHitShapeContainer>();
			set => SetPropertyValue<gameHitShapeContainer>(value);
		}

		public gameHitRepresentationVisualTaggedOverride()
		{
			VisualTags = new redTagList();
			RepresenationOverride = new gameHitShapeContainer();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
