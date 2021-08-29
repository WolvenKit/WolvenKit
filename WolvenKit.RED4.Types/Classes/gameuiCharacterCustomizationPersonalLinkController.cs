using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationPersonalLinkController : gameuiICharacterCustomizationComponent
	{
		private CName _simpleLinkGroup;

		[Ordinal(3)] 
		[RED("simpleLinkGroup")] 
		public CName SimpleLinkGroup
		{
			get => GetProperty(ref _simpleLinkGroup);
			set => SetProperty(ref _simpleLinkGroup, value);
		}
	}
}
