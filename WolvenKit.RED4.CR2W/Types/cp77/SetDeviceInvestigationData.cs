using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDeviceInvestigationData : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _ownerPuppet;
		private wCHandle<gameObject> _listener;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<ScriptedPuppet> OwnerPuppet
		{
			get
			{
				if (_ownerPuppet == null)
				{
					_ownerPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "ownerPuppet", cr2w, this);
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
		[RED("listener")] 
		public wCHandle<gameObject> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		public SetDeviceInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
