using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyRandomStatusEffectEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<TweakDBID> Effects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(3)] 
		[RED("appliedEffect")] 
		public TweakDBID AppliedEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyRandomStatusEffectEffector()
		{
			TargetEntityID = new entEntityID();
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
