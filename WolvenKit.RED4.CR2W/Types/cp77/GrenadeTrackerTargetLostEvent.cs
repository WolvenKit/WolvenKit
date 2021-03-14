using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeTrackerTargetLostEvent : redEvent
	{
		private wCHandle<ScriptedPuppet> _target;

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

		public GrenadeTrackerTargetLostEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
