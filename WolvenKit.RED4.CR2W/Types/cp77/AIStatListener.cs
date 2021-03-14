using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStatListener : gameScriptStatsListener
	{
		private wCHandle<ScriptedPuppet> _owner;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get
			{
				if (_behaviorCallbackName == null)
				{
					_behaviorCallbackName = (CName) CR2WTypeManager.Create("CName", "behaviorCallbackName", cr2w, this);
				}
				return _behaviorCallbackName;
			}
			set
			{
				if (_behaviorCallbackName == value)
				{
					return;
				}
				_behaviorCallbackName = value;
				PropertySet(this);
			}
		}

		public AIStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
