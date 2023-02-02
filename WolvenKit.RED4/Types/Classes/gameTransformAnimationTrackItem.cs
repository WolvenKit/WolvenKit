using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimationTrackItem : ISerializable
	{
		[Ordinal(0)] 
		[RED("impl")] 
		public CHandle<gameTransformAnimationTrackItemImpl> Impl
		{
			get => GetPropertyValue<CHandle<gameTransformAnimationTrackItemImpl>>();
			set => SetPropertyValue<CHandle<gameTransformAnimationTrackItemImpl>>(value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTransformAnimationTrackItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
