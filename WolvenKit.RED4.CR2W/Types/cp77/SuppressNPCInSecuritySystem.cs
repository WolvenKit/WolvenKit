using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressNPCInSecuritySystem : redEvent
	{
		private CBool _suppressIncomingEvents;
		private CBool _suppressOutgoingEvents;

		[Ordinal(0)] 
		[RED("suppressIncomingEvents")] 
		public CBool SuppressIncomingEvents
		{
			get => GetProperty(ref _suppressIncomingEvents);
			set => SetProperty(ref _suppressIncomingEvents, value);
		}

		[Ordinal(1)] 
		[RED("suppressOutgoingEvents")] 
		public CBool SuppressOutgoingEvents
		{
			get => GetProperty(ref _suppressOutgoingEvents);
			set => SetProperty(ref _suppressOutgoingEvents, value);
		}

		public SuppressNPCInSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
