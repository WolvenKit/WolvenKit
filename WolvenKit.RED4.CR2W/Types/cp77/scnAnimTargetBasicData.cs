using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimTargetBasicData : CVariable
	{
		private scnPerformerId _performerId;
		private CBool _isStart;
		private scnPerformerId _targetPerformerId;
		private CName _targetSlot;
		private Vector4 _targetOffsetEntitySpace;
		private Vector4 _staticTarget;
		private scnActorId _targetActorId;
		private scnPropId _targetPropId;
		private CEnum<scnLookAtTargetType> _targetType;

		[Ordinal(0)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(1)] 
		[RED("isStart")] 
		public CBool IsStart
		{
			get => GetProperty(ref _isStart);
			set => SetProperty(ref _isStart, value);
		}

		[Ordinal(2)] 
		[RED("targetPerformerId")] 
		public scnPerformerId TargetPerformerId
		{
			get => GetProperty(ref _targetPerformerId);
			set => SetProperty(ref _targetPerformerId, value);
		}

		[Ordinal(3)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}

		[Ordinal(4)] 
		[RED("targetOffsetEntitySpace")] 
		public Vector4 TargetOffsetEntitySpace
		{
			get => GetProperty(ref _targetOffsetEntitySpace);
			set => SetProperty(ref _targetOffsetEntitySpace, value);
		}

		[Ordinal(5)] 
		[RED("staticTarget")] 
		public Vector4 StaticTarget
		{
			get => GetProperty(ref _staticTarget);
			set => SetProperty(ref _staticTarget, value);
		}

		[Ordinal(6)] 
		[RED("targetActorId")] 
		public scnActorId TargetActorId
		{
			get => GetProperty(ref _targetActorId);
			set => SetProperty(ref _targetActorId, value);
		}

		[Ordinal(7)] 
		[RED("targetPropId")] 
		public scnPropId TargetPropId
		{
			get => GetProperty(ref _targetPropId);
			set => SetProperty(ref _targetPropId, value);
		}

		[Ordinal(8)] 
		[RED("targetType")] 
		public CEnum<scnLookAtTargetType> TargetType
		{
			get => GetProperty(ref _targetType);
			set => SetProperty(ref _targetType, value);
		}

		public scnAnimTargetBasicData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
