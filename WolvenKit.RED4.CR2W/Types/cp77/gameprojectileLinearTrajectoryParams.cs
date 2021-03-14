using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _startVel;

		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get
			{
				if (_startVel == null)
				{
					_startVel = (CFloat) CR2WTypeManager.Create("Float", "startVel", cr2w, this);
				}
				return _startVel;
			}
			set
			{
				if (_startVel == value)
				{
					return;
				}
				_startVel = value;
				PropertySet(this);
			}
		}

		public gameprojectileLinearTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
