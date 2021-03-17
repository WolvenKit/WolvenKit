using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatDetailedData : CVariable
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _limitMin;
		private CFloat _limitMax;
		private CFloat _value;
		private CArray<gameStatModifierDetailedData> _modifiers;
		private CBool _boolStatType;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("limitMin")] 
		public CFloat LimitMin
		{
			get => GetProperty(ref _limitMin);
			set => SetProperty(ref _limitMin, value);
		}

		[Ordinal(2)] 
		[RED("limitMax")] 
		public CFloat LimitMax
		{
			get => GetProperty(ref _limitMax);
			set => SetProperty(ref _limitMax, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(4)] 
		[RED("modifiers")] 
		public CArray<gameStatModifierDetailedData> Modifiers
		{
			get => GetProperty(ref _modifiers);
			set => SetProperty(ref _modifiers, value);
		}

		[Ordinal(5)] 
		[RED("boolStatType")] 
		public CBool BoolStatType
		{
			get => GetProperty(ref _boolStatType);
			set => SetProperty(ref _boolStatType, value);
		}

		public gameStatDetailedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
