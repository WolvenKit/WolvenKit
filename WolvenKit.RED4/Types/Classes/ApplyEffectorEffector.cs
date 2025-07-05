using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyEffectorEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
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
		[RED("effectorToApply")] 
		public TweakDBID EffectorToApply
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyEffectorEffector()
		{
			Target = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
