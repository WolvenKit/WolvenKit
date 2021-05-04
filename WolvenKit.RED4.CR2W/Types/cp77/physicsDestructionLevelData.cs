using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionLevelData : CVariable
	{
		private CHandle<physicsFilterData> _filterData;
		private raRef<worldEffect> _fracturingEffect;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("fracturingEffect")] 
		public raRef<worldEffect> FracturingEffect
		{
			get => GetProperty(ref _fracturingEffect);
			set => SetProperty(ref _fracturingEffect, value);
		}

		public physicsDestructionLevelData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
