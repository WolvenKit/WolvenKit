using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficPersistentData : CVariable
	{
		private CBool _invertTrafficEvents;

		[Ordinal(0)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get => GetProperty(ref _invertTrafficEvents);
			set => SetProperty(ref _invertTrafficEvents, value);
		}

		public TrafficPersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
