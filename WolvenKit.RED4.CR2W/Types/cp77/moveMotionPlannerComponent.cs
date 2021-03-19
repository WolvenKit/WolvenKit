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
			get => GetProperty(ref _snapToGround);
			set => SetProperty(ref _snapToGround, value);
		}

		public moveMotionPlannerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
