using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeTrackerTargetAcquiredEvent : redEvent
	{
		private wCHandle<ScriptedPuppet> _target;
		private CName _targetSlot;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<ScriptedPuppet> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get
			{
				if (_targetSlot == null)
				{
					_targetSlot = (CName) CR2WTypeManager.Create("CName", "targetSlot", cr2w, this);
				}
				return _targetSlot;
			}
			set
			{
				if (_targetSlot == value)
				{
					return;
				}
				_targetSlot = value;
				PropertySet(this);
			}
		}

		public GrenadeTrackerTargetAcquiredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
