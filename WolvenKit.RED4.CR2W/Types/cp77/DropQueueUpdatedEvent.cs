using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropQueueUpdatedEvent : redEvent
	{
		private CArray<gameItemModParams> _dropQueue;

		[Ordinal(0)] 
		[RED("dropQueue")] 
		public CArray<gameItemModParams> DropQueue
		{
			get => GetProperty(ref _dropQueue);
			set => SetProperty(ref _dropQueue, value);
		}

		public DropQueueUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
