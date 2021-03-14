using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HealthStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<HealthUpdateEvent> _healthEvent;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<PlayerPuppet> OwnerPuppet
		{
			get
			{
				if (_ownerPuppet == null)
				{
					_ownerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "ownerPuppet", cr2w, this);
				}
				return _ownerPuppet;
			}
			set
			{
				if (_ownerPuppet == value)
				{
					return;
				}
				_ownerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("healthEvent")] 
		public CHandle<HealthUpdateEvent> HealthEvent
		{
			get
			{
				if (_healthEvent == null)
				{
					_healthEvent = (CHandle<HealthUpdateEvent>) CR2WTypeManager.Create("handle:HealthUpdateEvent", "healthEvent", cr2w, this);
				}
				return _healthEvent;
			}
			set
			{
				if (_healthEvent == value)
				{
					return;
				}
				_healthEvent = value;
				PropertySet(this);
			}
		}

		public HealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
