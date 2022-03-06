
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTriggerAttackEffector_Record
	{
		[RED("applicationChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ApplicationChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackPositionSlotName")]
		[REDProperty(IsIgnored = true)]
		public CName AttackPositionSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("bodyPart")]
		[REDProperty(IsIgnored = true)]
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("chance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Chance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hitPosition")]
		[REDProperty(IsIgnored = true)]
		public Vector3 HitPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("isCritical")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isRandom")]
		[REDProperty(IsIgnored = true)]
		public CBool IsRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("playerAsInstigator")]
		[REDProperty(IsIgnored = true)]
		public CBool PlayerAsInstigator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldDelay")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldDelay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("triggerHitReaction")]
		[REDProperty(IsIgnored = true)]
		public CBool TriggerHitReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("woundType")]
		[REDProperty(IsIgnored = true)]
		public CName WoundType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
