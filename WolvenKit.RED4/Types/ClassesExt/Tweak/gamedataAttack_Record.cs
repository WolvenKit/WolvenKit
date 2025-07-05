
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_Record
	{
		[RED("attackName")]
		[REDProperty(IsIgnored = true)]
		public CName AttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("attackType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("className")]
		[REDProperty(IsIgnored = true)]
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("damageType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("explosionDamageVSVehicles")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExplosionDamageVSVehicles
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hitFlags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> HitFlags
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("hitReactionSeverityMax")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitReactionSeverityMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitReactionSeverityMin")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitReactionSeverityMin
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("playerIncomingDamageMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat PlayerIncomingDamageMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("staminaCost")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StaminaCost
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statusEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatusEffects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("useDefaultAimData")]
		[REDProperty(IsIgnored = true)]
		public CBool UseDefaultAimData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("userDataPath")]
		[REDProperty(IsIgnored = true)]
		public CString UserDataPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("velocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Velocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
