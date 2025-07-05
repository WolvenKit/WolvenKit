using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_CoverAction : animAnimFeature_AIAction
	{
		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("coverActionType")] 
		public CInt32 CoverActionType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("coverShootType")] 
		public CInt32 CoverShootType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_CoverAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
