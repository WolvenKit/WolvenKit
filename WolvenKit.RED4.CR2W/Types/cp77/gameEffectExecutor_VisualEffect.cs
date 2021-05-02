using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_VisualEffect : gameEffectExecutor
	{
		private raRef<worldEffect> _effect;
		private CBool _attached;
		private CBool _breakLoopOnDetach;
		private CName _effectTag;
		private CHandle<gameEffectVectorEvaluator> _vectorEvaluator;

		[Ordinal(1)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
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

		public gameEffectExecutor_VisualEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
