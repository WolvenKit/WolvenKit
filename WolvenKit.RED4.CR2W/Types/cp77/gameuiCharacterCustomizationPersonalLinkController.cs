using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationPersonalLinkController : gameuiICharacterCustomizationComponent
	{
		private CName _simpleLinkGroup;

		[Ordinal(3)] 
		[RED("simpleLinkGroup")] 
		public CName SimpleLinkGroup
		{
			get => GetProperty(ref _simpleLinkGroup);
			set => SetProperty(ref _simpleLinkGroup, value);
		}

		public gameuiCharacterCustomizationPersonalLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
