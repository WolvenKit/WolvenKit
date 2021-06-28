using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		private CArray<animGraphSlotCondition> _conditions;

		[Ordinal(14)] 
		[RED("conditions")] 
		public CArray<animGraphSlotCondition> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public animAnimNode_GraphSlotConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
