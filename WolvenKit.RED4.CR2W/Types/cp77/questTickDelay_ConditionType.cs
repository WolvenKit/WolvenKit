using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTickDelay_ConditionType : questITimeConditionType
	{
		private CUInt32 _tickCount;

		[Ordinal(0)] 
		[RED("tickCount")] 
		public CUInt32 TickCount
		{
			get => GetProperty(ref _tickCount);
			set => SetProperty(ref _tickCount, value);
		}

		public questTickDelay_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
