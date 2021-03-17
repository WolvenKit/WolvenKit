using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorTriggerDelayedEvent : redEvent
	{
		private wCHandle<gameObject> _activator;

		[Ordinal(0)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		public DoorTriggerDelayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
