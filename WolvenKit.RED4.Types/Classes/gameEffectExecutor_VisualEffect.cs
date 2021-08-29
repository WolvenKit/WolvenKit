using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_VisualEffect : gameEffectExecutor
	{
		private CResourceAsyncReference<worldEffect> _effect;
		private CBool _attached;
		private CBool _breakLoopOnDetach;
		private CName _effectTag;
		private CHandle<gameEffectVectorEvaluator> _vectorEvaluator;

		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(2)] 
		[RED("attached")] 
		public CBool Attached
		{
			get => GetProperty(ref _attached);
			set => SetProperty(ref _attached, value);
		}

		[Ordinal(3)] 
		[RED("breakLoopOnDetach")] 
		public CBool BreakLoopOnDetach
		{
			get => GetProperty(ref _breakLoopOnDetach);
			set => SetProperty(ref _breakLoopOnDetach, value);
		}

		[Ordinal(4)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		[Ordinal(5)] 
		[RED("vectorEvaluator")] 
		public CHandle<gameEffectVectorEvaluator> VectorEvaluator
		{
			get => GetProperty(ref _vectorEvaluator);
			set => SetProperty(ref _vectorEvaluator, value);
		}
	}
}
