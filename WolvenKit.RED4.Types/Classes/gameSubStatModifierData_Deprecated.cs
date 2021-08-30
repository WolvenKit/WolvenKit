using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSubStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		private CEnum<gamedataStatType> _refStatType;

		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get => GetProperty(ref _refStatType);
			set => SetProperty(ref _refStatType, value);
		}

		public gameSubStatModifierData_Deprecated()
		{
			_refStatType = new() { Value = Enums.gamedataStatType.Invalid };
		}
	}
}
