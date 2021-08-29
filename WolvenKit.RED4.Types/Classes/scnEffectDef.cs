using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnEffectDef : RedBaseClass
	{
		private scnEffectId _id;
		private CResourceAsyncReference<worldEffect> _effect;

		[Ordinal(0)] 
		[RED("id")] 
		public scnEffectId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}
	}
}
