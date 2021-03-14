using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HidePuppetDelayEvent : redEvent
	{
		private wCHandle<NPCPuppet> _target;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<NPCPuppet> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "target", cr2w, this);
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

		public HidePuppetDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
