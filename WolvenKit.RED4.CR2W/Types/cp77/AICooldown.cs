using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICooldown : AITimeCondition
	{
		private CFloat _cooldown;
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (CFloat) CR2WTypeManager.Create("Float", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		public AICooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
