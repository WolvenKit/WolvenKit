using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navLocomotionPathPointInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("point")] 
		public navSerializableSplineProgression Point
		{
			get => GetPropertyValue<navSerializableSplineProgression>();
			set => SetPropertyValue<navSerializableSplineProgression>(value);
		}

		[Ordinal(1)] 
		[RED("userDataIndex")] 
		public CUInt32 UserDataIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public navLocomotionPathPointInfo()
		{
			Point = new navSerializableSplineProgression();
			UserDataIndex = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
