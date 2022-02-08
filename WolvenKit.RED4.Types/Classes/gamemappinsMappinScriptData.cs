using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsMappinScriptData : IScriptable
	{
		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public gamemappinsMappinScriptData()
		{
			StatPoolType = Enums.gamedataStatPoolType.Invalid;
		}
	}
}
