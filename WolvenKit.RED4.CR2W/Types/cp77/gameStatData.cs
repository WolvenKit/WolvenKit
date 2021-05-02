using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatData : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _modifiers;
		private CEnum<gamedataStatType> _statType;

		[Ordinal(0)] 
		[RED("modifiers")] 
		public CArray<CHandle<gameStatModifierData>> Modifiers
		{
			get => GetProperty(ref _modifiers);
			set => SetProperty(ref _modifiers, value);
		}

		[Ordinal(1)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		public gameStatData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
