using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionSetVehicleSuspensionData : scnIGameplayActionData
	{
		private CBool _active;
		private CFloat _cooldownTime;

		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get
			{
				if (_cooldownTime == null)
				{
					_cooldownTime = (CFloat) CR2WTypeManager.Create("Float", "cooldownTime", cr2w, this);
				}
				return _cooldownTime;
			}
			set
			{
				if (_cooldownTime == value)
				{
					return;
				}
				_cooldownTime = value;
				PropertySet(this);
			}
		}

		public scnGameplayActionSetVehicleSuspensionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
