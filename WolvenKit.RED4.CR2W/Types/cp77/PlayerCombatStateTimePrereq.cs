using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		private CFloat _minTime;
		private CFloat _maxTime;

		[Ordinal(0)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get
			{
				if (_minTime == null)
				{
					_minTime = (CFloat) CR2WTypeManager.Create("Float", "minTime", cr2w, this);
				}
				return _minTime;
			}
			set
			{
				if (_minTime == value)
				{
					return;
				}
				_minTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get
			{
				if (_maxTime == null)
				{
					_maxTime = (CFloat) CR2WTypeManager.Create("Float", "maxTime", cr2w, this);
				}
				return _maxTime;
			}
			set
			{
				if (_maxTime == value)
				{
					return;
				}
				_maxTime = value;
				PropertySet(this);
			}
		}

		public PlayerCombatStateTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
