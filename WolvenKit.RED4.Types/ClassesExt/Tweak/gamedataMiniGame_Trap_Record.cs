
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMiniGame_Trap_Record
	{
		[RED("negativeTrap")]
		[REDProperty(IsIgnored = true)]
		public CBool NegativeTrap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("spawnProbability")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("trapDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper TrapDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("trapIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TrapIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("trapName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper TrapName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("trapType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TrapType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
