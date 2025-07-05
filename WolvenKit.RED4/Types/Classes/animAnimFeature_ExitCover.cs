using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_ExitCover : animAnimFeature_AIAction
	{
		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("coverExitDirection")] 
		public CInt32 CoverExitDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_ExitCover()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
