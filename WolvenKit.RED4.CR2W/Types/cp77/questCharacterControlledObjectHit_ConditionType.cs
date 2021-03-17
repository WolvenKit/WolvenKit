using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterControlledObjectHit_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _attackerRef;
		private gameEntityReference _targetRef;
		private CBool _isTargetPlayer;
		private CArray<CEnum<questCharacterHitEventType>> _includeHitTypes;
		private CArray<CEnum<questCharacterHitEventType>> _excludeHitTypes;
		private CArray<CName> _includeHitShapes;
		private CArray<CName> _excludeHitShapes;

		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get => GetProperty(ref _attackerRef);
			set => SetProperty(ref _attackerRef, value);
		}

		[Ordinal(1)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(2)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get => GetProperty(ref _isTargetPlayer);
			set => SetProperty(ref _isTargetPlayer, value);
		}

		[Ordinal(3)] 
		[RED("includeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> IncludeHitTypes
		{
			get => GetProperty(ref _includeHitTypes);
			set => SetProperty(ref _includeHitTypes, value);
		}

		[Ordinal(4)] 
		[RED("excludeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> ExcludeHitTypes
		{
			get => GetProperty(ref _excludeHitTypes);
			set => SetProperty(ref _excludeHitTypes, value);
		}

		[Ordinal(5)] 
		[RED("includeHitShapes")] 
		public CArray<CName> IncludeHitShapes
		{
			get => GetProperty(ref _includeHitShapes);
			set => SetProperty(ref _includeHitShapes, value);
		}

		[Ordinal(6)] 
		[RED("excludeHitShapes")] 
		public CArray<CName> ExcludeHitShapes
		{
			get => GetProperty(ref _excludeHitShapes);
			set => SetProperty(ref _excludeHitShapes, value);
		}

		public questCharacterControlledObjectHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
