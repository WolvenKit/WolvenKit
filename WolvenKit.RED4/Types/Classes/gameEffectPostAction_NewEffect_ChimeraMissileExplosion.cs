using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectPostAction_NewEffect_ChimeraMissileExplosion : gameEffectPostAction
	{
		[Ordinal(0)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("overrideRadius")] 
		public CFloat OverrideRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("executeOnNthHit")] 
		public CInt32 ExecuteOnNthHit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameEffectPostAction_NewEffect_ChimeraMissileExplosion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
