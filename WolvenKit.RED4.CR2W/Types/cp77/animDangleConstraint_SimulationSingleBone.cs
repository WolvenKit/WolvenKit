using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSingleBone : animDangleConstraint_Simulation
	{
		private animTransformIndex _dangleBone;

		[Ordinal(13)] 
		[RED("dangleBone")] 
		public animTransformIndex DangleBone
		{
			get
			{
				if (_dangleBone == null)
				{
					_dangleBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "dangleBone", cr2w, this);
				}
				return _dangleBone;
			}
			set
			{
				if (_dangleBone == value)
				{
					return;
				}
				_dangleBone = value;
				PropertySet(this);
			}
		}

		public animDangleConstraint_SimulationSingleBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
