using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPostAction_Beam_RicochetPreviewPreviewEffect : RedBaseClass
	{
		private CResourceAsyncReference<worldEffect> _effect;
		private CName _effectTag;
		private CResourceAsyncReference<worldEffect> _effectSnap;
		private CName _effectSnapTag;
		private CFloat _forwardOffset;

		[Ordinal(0)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
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
		public CResourceAsyncReference<worldEffect> EffectSnap
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
	}
}
