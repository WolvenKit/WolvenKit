using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreviewPreviewEffect : CVariable
	{
		private raRef<worldEffect> _effect;
		private CName _effectTag;
		private raRef<worldEffect> _effectSnap;
		private CName _effectSnapTag;
		private CFloat _forwardOffset;

		[Ordinal(0)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		[Ordinal(2)] 
		[RED("effectSnap")] 
		public raRef<worldEffect> EffectSnap
		{
			get => GetProperty(ref _effectSnap);
			set => SetProperty(ref _effectSnap, value);
		}

		[Ordinal(3)] 
		[RED("effectSnapTag")] 
		public CName EffectSnapTag
		{
			get => GetProperty(ref _effectSnapTag);
			set => SetProperty(ref _effectSnapTag, value);
		}

		[Ordinal(4)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetProperty(ref _forwardOffset);
			set => SetProperty(ref _forwardOffset, value);
		}

		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
