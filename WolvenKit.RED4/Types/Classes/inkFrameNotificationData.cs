using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkFrameNotificationData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("frame")] 
		public CWeakHandle<Frame> Frame
		{
			get => GetPropertyValue<CWeakHandle<Frame>>();
			set => SetPropertyValue<CWeakHandle<Frame>>(value);
		}

		[Ordinal(8)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("uv")] 
		public RectF Uv
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		[Ordinal(11)] 
		[RED("shouldApply")] 
		public CBool ShouldApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkFrameNotificationData()
		{
			Uv = new RectF();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
