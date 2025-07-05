using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_Laser : gameEffectObjectProvider_PhysicalRay
	{
		[Ordinal(6)] 
		[RED("inputTracesPerSecond")] 
		public CUInt32 InputTracesPerSecond
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("inputRayOffset")] 
		public Vector4 InputRayOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameEffectObjectProvider_Laser()
		{
			InputRayOffset = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
