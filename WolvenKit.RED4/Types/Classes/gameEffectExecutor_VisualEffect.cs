using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_VisualEffect : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(2)] 
		[RED("attached")] 
		public CBool Attached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("breakLoopOnDetach")] 
		public CBool BreakLoopOnDetach
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

		[Ordinal(5)] 
		[RED("vectorEvaluator")] 
		public CHandle<gameEffectVectorEvaluator> VectorEvaluator
		{
			get => GetPropertyValue<CHandle<gameEffectVectorEvaluator>>();
			set => SetPropertyValue<CHandle<gameEffectVectorEvaluator>>(value);
		}

		public gameEffectExecutor_VisualEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
