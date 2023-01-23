
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionMeleeAttackManager_Record
	{
		[RED("fxDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat FxDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sendFriendlyFireWarning")]
		[REDProperty(IsIgnored = true)]
		public CBool SendFriendlyFireWarning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("spawnTrail")]
		[REDProperty(IsIgnored = true)]
		public CBool SpawnTrail
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("spawnWeaponFX")]
		[REDProperty(IsIgnored = true)]
		public CBool SpawnWeaponFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("trailDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrailDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("trailDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrailDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("warningDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat WarningDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
