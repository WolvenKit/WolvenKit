using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FrameSwitcherEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("frame")] 
		public CWeakHandle<Frame> Frame
		{
			get => GetPropertyValue<CWeakHandle<Frame>>();
			set => SetPropertyValue<CWeakHandle<Frame>>(value);
		}

		[Ordinal(1)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("uv")] 
		public RectF Uv
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		public FrameSwitcherEvent()
		{
			Uv = new RectF();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
