using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemLookAtObjectChangedEvent : redEvent
	{
		private wCHandle<gameObject> _lookatObject;

		[Ordinal(0)] 
		[RED("lookatObject")] 
		public wCHandle<gameObject> LookatObject
		{
			get => GetProperty(ref _lookatObject);
			set => SetProperty(ref _lookatObject, value);
		}

		public gametargetingSystemLookAtObjectChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
