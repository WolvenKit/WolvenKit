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
			get
			{
				if (_simpleLinkGroup == null)
				{
					_simpleLinkGroup = (CName) CR2WTypeManager.Create("CName", "simpleLinkGroup", cr2w, this);
				}
				return _simpleLinkGroup;
			}
			set
			{
				if (_simpleLinkGroup == value)
				{
					return;
				}
				_simpleLinkGroup = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationPersonalLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
