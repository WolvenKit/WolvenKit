using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IgnoreListEvent : redEvent
	{
		private entEntityID _bodyID;
		private CBool _removeEvent;

		[Ordinal(0)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get => GetProperty(ref _bodyID);
			set => SetProperty(ref _bodyID, value);
		}

		[Ordinal(1)] 
		[RED("removeEvent")] 
		public CBool RemoveEvent
		{
			get => GetProperty(ref _removeEvent);
			set => SetProperty(ref _removeEvent, value);
		}

		public IgnoreListEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
