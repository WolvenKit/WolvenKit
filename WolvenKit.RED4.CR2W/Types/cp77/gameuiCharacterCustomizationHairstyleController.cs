using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _headGroupName;

		[Ordinal(3)] 
		[RED("headGroupName")] 
		public CName HeadGroupName
		{
			get
			{
				if (_headGroupName == null)
				{
					_headGroupName = (CName) CR2WTypeManager.Create("CName", "headGroupName", cr2w, this);
				}
				return _headGroupName;
			}
			set
			{
				if (_headGroupName == value)
				{
					return;
				}
				_headGroupName = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationHairstyleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
