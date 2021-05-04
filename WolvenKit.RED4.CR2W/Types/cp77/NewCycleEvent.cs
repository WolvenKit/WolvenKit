using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewCycleEvent : redEvent
	{
		private CUInt16 _cyclesCount;

		[Ordinal(0)] 
		[RED("cyclesCount")] 
		public CUInt16 CyclesCount
		{
			get => GetProperty(ref _cyclesCount);
			set => SetProperty(ref _cyclesCount, value);
		}

		public NewCycleEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
