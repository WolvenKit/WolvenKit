using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckAnimSetTags : AIbehaviorconditionScript
	{
		private CArray<CName> _animsetTagToCompare;

		[Ordinal(0)] 
		[RED("animsetTagToCompare")] 
		public CArray<CName> AnimsetTagToCompare
		{
			get => GetProperty(ref _animsetTagToCompare);
			set => SetProperty(ref _animsetTagToCompare, value);
		}
	}
}
