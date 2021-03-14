using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveMotionPlannerComponent : moveIMotionPlannerComponent
	{
		private CBool _snapToGround;

		[Ordinal(3)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get
			{
				if (_snapToGround == null)
				{
					_snapToGround = (CBool) CR2WTypeManager.Create("Bool", "snapToGround", cr2w, this);
				}
				return _snapToGround;
			}
			set
			{
				if (_snapToGround == value)
				{
					return;
				}
				_snapToGround = value;
				PropertySet(this);
			}
		}

		public moveMotionPlannerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
