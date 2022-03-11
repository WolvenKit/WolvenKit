
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHitPrereqCondition_Record
	{
		[RED("ammoState")]
		[REDProperty(IsIgnored = true)]
		public CString AmmoState
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("attackSubtype")]
		[REDProperty(IsIgnored = true)]
		public CString AttackSubtype
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("attackType")]
		[REDProperty(IsIgnored = true)]
		public CString AttackType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("bodyPart")]
		[REDProperty(IsIgnored = true)]
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("checkType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CheckType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("comparisonSource")]
		[REDProperty(IsIgnored = true)]
		public CName ComparisonSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("comparisonTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ComparisonTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("comparisonType")]
		[REDProperty(IsIgnored = true)]
		public CString ComparisonType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("distanceRequired")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceRequired
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dotType")]
		[REDProperty(IsIgnored = true)]
		public CString DotType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("hitFlag")]
		[REDProperty(IsIgnored = true)]
		public CString HitFlag
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("instigatorType")]
		[REDProperty(IsIgnored = true)]
		public CName InstigatorType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isMoving")]
		[REDProperty(IsIgnored = true)]
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("npcType")]
		[REDProperty(IsIgnored = true)]
		public CString NpcType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("object")]
		[REDProperty(IsIgnored = true)]
		public CName Object
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("objectToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("onlyOncePerShot")]
		[REDProperty(IsIgnored = true)]
		public CBool OnlyOncePerShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("rarity")]
		[REDProperty(IsIgnored = true)]
		public CString Rarity
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("source")]
		[REDProperty(IsIgnored = true)]
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statPoolToCompare")]
		[REDProperty(IsIgnored = true)]
		public CString StatPoolToCompare
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public CName StatusEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("tagToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName TagToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("targetType")]
		[REDProperty(IsIgnored = true)]
		public CName TargetType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("valueToCheck")]
		[REDProperty(IsIgnored = true)]
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponType")]
		[REDProperty(IsIgnored = true)]
		public CName WeaponType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
