using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectRef : RedBaseClass
	{
		private CResourceReference<gameEffectSet> _set;
		private CName _tag;

		[Ordinal(0)] 
		[RED("set")] 
		public CResourceReference<gameEffectSet> Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}
	}
}
