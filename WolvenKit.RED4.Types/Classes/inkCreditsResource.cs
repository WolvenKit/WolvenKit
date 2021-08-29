using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCreditsResource : CResource
	{
		private CArray<inkCreditsSectionEntry> _sections;

		[Ordinal(1)] 
		[RED("sections")] 
		public CArray<inkCreditsSectionEntry> Sections
		{
			get => GetProperty(ref _sections);
			set => SetProperty(ref _sections, value);
		}
	}
}
