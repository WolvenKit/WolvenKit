using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCursorInterpolationOverrides : inkUserData
	{
		private Vector2 _minSpeed;
		private CFloat _enterTime;

		[Ordinal(0)] 
		[RED("minSpeed")] 
		public Vector2 MinSpeed
		{
			get
			{
				if (_minSpeed == null)
				{
					_minSpeed = (Vector2) CR2WTypeManager.Create("Vector2", "minSpeed", cr2w, this);
				}
				return _minSpeed;
			}
			set
			{
				if (_minSpeed == value)
				{
					return;
				}
				_minSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get
			{
				if (_enterTime == null)
				{
					_enterTime = (CFloat) CR2WTypeManager.Create("Float", "enterTime", cr2w, this);
				}
				return _enterTime;
			}
			set
			{
				if (_enterTime == value)
				{
					return;
				}
				_enterTime = value;
				PropertySet(this);
			}
		}

		public gameCursorInterpolationOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
