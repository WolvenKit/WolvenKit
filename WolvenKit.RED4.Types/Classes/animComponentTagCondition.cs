using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animComponentTagCondition : animIStaticCondition
	{
		private CName _animTag;

		[Ordinal(0)] 
		[RED("animTag")] 
		public CName AnimTag
		{
			get => GetProperty(ref _animTag);
			set => SetProperty(ref _animTag, value);
		}
	}
}
