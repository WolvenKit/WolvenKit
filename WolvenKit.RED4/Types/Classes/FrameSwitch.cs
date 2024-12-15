using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FrameSwitch : redEvent
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("uv")] 
		public RectF Uv
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		public FrameSwitch()
		{
			Uv = new RectF();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
