using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _stickiness;
		private Vector4 _constAccel;

		[Ordinal(0)] 
		[RED("stickiness")] 
		public CFloat Stickiness
		{
			get
			{
				if (_stickiness == null)
				{
					_stickiness = (CFloat) CR2WTypeManager.Create("Float", "stickiness", cr2w, this);
				}
				return _stickiness;
			}
			set
			{
				if (_stickiness == value)
				{
					return;
				}
				_stickiness = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("constAccel")] 
		public Vector4 ConstAccel
		{
			get
			{
				if (_constAccel == null)
				{
					_constAccel = (Vector4) CR2WTypeManager.Create("Vector4", "constAccel", cr2w, this);
				}
				return _constAccel;
			}
			set
			{
				if (_constAccel == value)
				{
					return;
				}
				_constAccel = value;
				PropertySet(this);
			}
		}

		public gameprojectileSlideTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
