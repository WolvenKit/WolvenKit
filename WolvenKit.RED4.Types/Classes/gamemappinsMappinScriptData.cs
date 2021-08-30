using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsMappinScriptData : IScriptable
	{
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		public gamemappinsMappinScriptData()
		{
			_statPoolType = new() { Value = Enums.gamedataStatPoolType.Invalid };
		}
	}
}
