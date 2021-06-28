using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_StatData : CVariable
	{
		private CEnum<gamedataStatType> _statType;
		private CString _statName;
		private CInt32 _minStatValue;
		private CInt32 _maxStatValue;
		private CInt32 _currentValue;
		private CInt32 _diffValue;
		private CFloat _minStatValueF;
		private CFloat _maxStatValueF;
		private CFloat _currentValueF;
		private CFloat _diffValueF;
		private CEnum<EInventoryDataStatDisplayType> _state;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(2)] 
		[RED("minStatValue")] 
		public CInt32 MinStatValue
		{
			get => GetProperty(ref _minStatValue);
			set => SetProperty(ref _minStatValue, value);
		}

		[Ordinal(3)] 
		[RED("maxStatValue")] 
		public CInt32 MaxStatValue
		{
			get => GetProperty(ref _maxStatValue);
			set => SetProperty(ref _maxStatValue, value);
		}

		[Ordinal(4)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(5)] 
		[RED("diffValue")] 
		public CInt32 DiffValue
		{
			get => GetProperty(ref _diffValue);
			set => SetProperty(ref _diffValue, value);
		}

		[Ordinal(6)] 
		[RED("minStatValueF")] 
		public CFloat MinStatValueF
		{
			get => GetProperty(ref _minStatValueF);
			set => SetProperty(ref _minStatValueF, value);
		}

		[Ordinal(7)] 
		[RED("maxStatValueF")] 
		public CFloat MaxStatValueF
		{
			get => GetProperty(ref _maxStatValueF);
			set => SetProperty(ref _maxStatValueF, value);
		}

		[Ordinal(8)] 
		[RED("currentValueF")] 
		public CFloat CurrentValueF
		{
			get => GetProperty(ref _currentValueF);
			set => SetProperty(ref _currentValueF, value);
		}

		[Ordinal(9)] 
		[RED("diffValueF")] 
		public CFloat DiffValueF
		{
			get => GetProperty(ref _diffValueF);
			set => SetProperty(ref _diffValueF, value);
		}

		[Ordinal(10)] 
		[RED("state")] 
		public CEnum<EInventoryDataStatDisplayType> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public InventoryTooltipData_StatData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
