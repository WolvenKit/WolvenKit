using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimSetSRRef : CVariable
	{
		private CArray<scnSRRefId> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnSRRefId> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<scnSRRefId>) CR2WTypeManager.Create("array:scnSRRefId", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		public scnRidAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
