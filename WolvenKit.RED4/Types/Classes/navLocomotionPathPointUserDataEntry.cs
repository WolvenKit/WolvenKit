using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navLocomotionPathPointUserDataEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("userData")] 
		public CHandle<navLocomotionPathPointUserData> UserData
		{
			get => GetPropertyValue<CHandle<navLocomotionPathPointUserData>>();
			set => SetPropertyValue<CHandle<navLocomotionPathPointUserData>>(value);
		}

		[Ordinal(1)] 
		[RED("nextUserData")] 
		public CUInt32 NextUserData
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public navLocomotionPathPointUserDataEntry()
		{
			NextUserData = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
