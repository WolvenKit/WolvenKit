using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LaserSight : Attack_Beam
	{
		private wCHandle<entEntity> _previousTarget;

		[Ordinal(0)] 
		[RED("previousTarget")] 
		public wCHandle<entEntity> PreviousTarget
		{
			get
			{
				if (_previousTarget == null)
				{
					_previousTarget = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "previousTarget", cr2w, this);
				}
				return _previousTarget;
			}
			set
			{
				if (_previousTarget == value)
				{
					return;
				}
				_previousTarget = value;
				PropertySet(this);
			}
		}

		public LaserSight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
