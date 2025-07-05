using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterHit_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isAttackerPlayer")] 
		public CBool IsAttackerPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("includeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> IncludeHitTypes
		{
			get => GetPropertyValue<CArray<CEnum<questCharacterHitEventType>>>();
			set => SetPropertyValue<CArray<CEnum<questCharacterHitEventType>>>(value);
		}

		[Ordinal(5)] 
		[RED("excludeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> ExcludeHitTypes
		{
			get => GetPropertyValue<CArray<CEnum<questCharacterHitEventType>>>();
			set => SetPropertyValue<CArray<CEnum<questCharacterHitEventType>>>(value);
		}

		[Ordinal(6)] 
		[RED("includeHitShapes")] 
		public CArray<CName> IncludeHitShapes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(7)] 
		[RED("excludeHitShapes")] 
		public CArray<CName> ExcludeHitShapes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questCharacterHit_ConditionType()
		{
			AttackerRef = new gameEntityReference { Names = new() };
			TargetRef = new gameEntityReference { Names = new() };
			IncludeHitTypes = new();
			ExcludeHitTypes = new();
			IncludeHitShapes = new();
			ExcludeHitShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
