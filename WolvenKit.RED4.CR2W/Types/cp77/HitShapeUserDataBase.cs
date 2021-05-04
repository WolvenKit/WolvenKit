using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitShapeUserDataBase : gameHitShapeUserData
	{
		private CName _hitShapeTag;
		private CEnum<EHitShapeType> _hitShapeType;
		private CEnum<EHitReactionZone> _hitReactionZone;
		private CEnum<EAIDismembermentBodyPart> _dismembermentPart;
		private CBool _isProtectionLayer;
		private CBool _isInternalWeakspot;
		private CFloat _hitShapeDamageMod;

		[Ordinal(0)] 
		[RED("hitShapeTag")] 
		public CName HitShapeTag
		{
			get => GetProperty(ref _hitShapeTag);
			set => SetProperty(ref _hitShapeTag, value);
		}

		[Ordinal(1)] 
		[RED("hitShapeType")] 
		public CEnum<EHitShapeType> HitShapeType
		{
			get => GetProperty(ref _hitShapeType);
			set => SetProperty(ref _hitShapeType, value);
		}

		[Ordinal(2)] 
		[RED("hitReactionZone")] 
		public CEnum<EHitReactionZone> HitReactionZone
		{
			get => GetProperty(ref _hitReactionZone);
			set => SetProperty(ref _hitReactionZone, value);
		}

		[Ordinal(3)] 
		[RED("dismembermentPart")] 
		public CEnum<EAIDismembermentBodyPart> DismembermentPart
		{
			get => GetProperty(ref _dismembermentPart);
			set => SetProperty(ref _dismembermentPart, value);
		}

		[Ordinal(4)] 
		[RED("isProtectionLayer")] 
		public CBool IsProtectionLayer
		{
			get => GetProperty(ref _isProtectionLayer);
			set => SetProperty(ref _isProtectionLayer, value);
		}

		[Ordinal(5)] 
		[RED("isInternalWeakspot")] 
		public CBool IsInternalWeakspot
		{
			get => GetProperty(ref _isInternalWeakspot);
			set => SetProperty(ref _isInternalWeakspot, value);
		}

		[Ordinal(6)] 
		[RED("hitShapeDamageMod")] 
		public CFloat HitShapeDamageMod
		{
			get => GetProperty(ref _hitShapeDamageMod);
			set => SetProperty(ref _hitShapeDamageMod, value);
		}

		public HitShapeUserDataBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
