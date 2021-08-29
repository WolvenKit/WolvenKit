using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeMappinData : gamemappinsMappinScriptData
	{
		private CEnum<EGrenadeType> _grenadeType;
		private TweakDBID _iconID;

		[Ordinal(1)] 
		[RED("grenadeType")] 
		public CEnum<EGrenadeType> GrenadeType
		{
			get => GetProperty(ref _grenadeType);
			set => SetProperty(ref _grenadeType, value);
		}

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}
	}
}
