using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCurveStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		private CName _curveName;
		private CName _columnName;
		private CEnum<gamedataStatType> _curveStat;

		[Ordinal(2)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get => GetProperty(ref _curveName);
			set => SetProperty(ref _curveName, value);
		}

		[Ordinal(3)] 
		[RED("columnName")] 
		public CName ColumnName
		{
			get => GetProperty(ref _columnName);
			set => SetProperty(ref _columnName, value);
		}

		[Ordinal(4)] 
		[RED("curveStat")] 
		public CEnum<gamedataStatType> CurveStat
		{
			get => GetProperty(ref _curveStat);
			set => SetProperty(ref _curveStat, value);
		}

		public gameCurveStatModifierData_Deprecated()
		{
			_curveStat = new() { Value = Enums.gamedataStatType.Invalid };
		}
	}
}
