using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitShapeUserDataBase : gameHitShapeUserData
	{
		[Ordinal(0)] 
		[RED("hitShapeTag")] 
		public CName HitShapeTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("hitShapeType")] 
		public CEnum<EHitShapeType> HitShapeType
		{
			get => GetPropertyValue<CEnum<EHitShapeType>>();
			set => SetPropertyValue<CEnum<EHitShapeType>>(value);
		}

		[Ordinal(2)] 
		[RED("hitReactionZone")] 
		public CEnum<EHitReactionZone> HitReactionZone
		{
			get => GetPropertyValue<CEnum<EHitReactionZone>>();
			set => SetPropertyValue<CEnum<EHitReactionZone>>(value);
		}

		[Ordinal(3)] 
		[RED("dismembermentPart")] 
		public CEnum<EAIDismembermentBodyPart> DismembermentPart
		{
			get => GetPropertyValue<CEnum<EAIDismembermentBodyPart>>();
			set => SetPropertyValue<CEnum<EAIDismembermentBodyPart>>(value);
		}

		[Ordinal(4)] 
		[RED("isProtectionLayer")] 
		public CBool IsProtectionLayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("quickHacksPierceProtection")] 
		public CBool QuickHacksPierceProtection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isInternalWeakspot")] 
		public CBool IsInternalWeakspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("hitShapeDamageMod")] 
		public CFloat HitShapeDamageMod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HitShapeUserDataBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
