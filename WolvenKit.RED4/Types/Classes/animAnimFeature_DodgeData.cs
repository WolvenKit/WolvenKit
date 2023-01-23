using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_DodgeData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("dodgeType")] 
		public CInt32 DodgeType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("dodgeDirection")] 
		public CInt32 DodgeDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_DodgeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
