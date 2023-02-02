using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectPostAction_BeamVFX_Custom : gameEffectPostAction_BeamVFX
	{
		[Ordinal(0)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(1)] 
		[RED("attached")] 
		public CBool Attached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("breakLoopOnDetach")] 
		public CBool BreakLoopOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectPostAction_BeamVFX_Custom()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
