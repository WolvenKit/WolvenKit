using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintMulti : animIDyngConstraint
	{
		private CArray<CHandle<animIDyngConstraint>> _innerConstraints;

		[Ordinal(1)] 
		[RED("innerConstraints")] 
		public CArray<CHandle<animIDyngConstraint>> InnerConstraints
		{
			get
			{
				if (_innerConstraints == null)
				{
					_innerConstraints = (CArray<CHandle<animIDyngConstraint>>) CR2WTypeManager.Create("array:handle:animIDyngConstraint", "innerConstraints", cr2w, this);
				}
				return _innerConstraints;
			}
			set
			{
				if (_innerConstraints == value)
				{
					return;
				}
				_innerConstraints = value;
				PropertySet(this);
			}
		}

		public animDyngConstraintMulti(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
