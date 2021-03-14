using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Dangle : animAnimNode_OnePoseInput
	{
		private CHandle<animDangleConstraint_Simulation> _dangleConstraint;

		[Ordinal(12)] 
		[RED("dangleConstraint")] 
		public CHandle<animDangleConstraint_Simulation> DangleConstraint
		{
			get
			{
				if (_dangleConstraint == null)
				{
					_dangleConstraint = (CHandle<animDangleConstraint_Simulation>) CR2WTypeManager.Create("handle:animDangleConstraint_Simulation", "dangleConstraint", cr2w, this);
				}
				return _dangleConstraint;
			}
			set
			{
				if (_dangleConstraint == value)
				{
					return;
				}
				_dangleConstraint = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Dangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
