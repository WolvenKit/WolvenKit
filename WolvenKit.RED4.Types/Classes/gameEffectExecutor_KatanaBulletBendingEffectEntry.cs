using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_KatanaBulletBendingEffectEntry : RedBaseClass
	{
		private CName _tag;
		private CResourceAsyncReference<worldEffect> _effect;
		private CBool _attach;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(2)] 
		[RED("attach")] 
		public CBool Attach
		{
			get => GetProperty(ref _attach);
			set => SetProperty(ref _attach, value);
		}
	}
}
