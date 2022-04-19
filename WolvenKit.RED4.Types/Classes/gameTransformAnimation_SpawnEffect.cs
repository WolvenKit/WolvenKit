using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_SpawnEffect : gameTransformAnimation_Effects
	{
		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTransformAnimation_SpawnEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
