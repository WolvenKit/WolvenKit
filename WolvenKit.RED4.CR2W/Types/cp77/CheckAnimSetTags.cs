using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckAnimSetTags : AIbehaviorconditionScript
	{
		private CArray<CName> _animsetTagToCompare;

		[Ordinal(0)] 
		[RED("animsetTagToCompare")] 
		public CArray<CName> AnimsetTagToCompare
		{
			get
			{
				if (_animsetTagToCompare == null)
				{
					_animsetTagToCompare = (CArray<CName>) CR2WTypeManager.Create("array:CName", "animsetTagToCompare", cr2w, this);
				}
				return _animsetTagToCompare;
			}
			set
			{
				if (_animsetTagToCompare == value)
				{
					return;
				}
				_animsetTagToCompare = value;
				PropertySet(this);
			}
		}

		public CheckAnimSetTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
