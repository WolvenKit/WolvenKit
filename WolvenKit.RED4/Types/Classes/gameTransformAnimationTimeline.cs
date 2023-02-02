using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimationTimeline : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameTransformAnimationTrackItem> Items
		{
			get => GetPropertyValue<CArray<gameTransformAnimationTrackItem>>();
			set => SetPropertyValue<CArray<gameTransformAnimationTrackItem>>(value);
		}

		public gameTransformAnimationTimeline()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
