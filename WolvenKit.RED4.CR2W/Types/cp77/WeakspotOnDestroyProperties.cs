using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotOnDestroyProperties : CVariable
	{
		private CBool _isInternal;
		private CBool _disableInteraction;
		private CBool _destroyMesh;
		private CBool _disableCollider;
		private CName _hideMeshParameterValue;
		private CBool _playHitFxFromOwnerEntity;
		private CBool _playDestroyedFxFromOwnerEntity;
		private CBool _playBrokenFxFromOwnerEntity;
		private CName _addFact;
		private CName _sendAIActionAnimFeatureName;
		private CInt32 _sendAIActionAnimFeatureState;
		private CFloat _destroyDelay;
		private CBool _useWeakspotDestroyStageVFX;
		private TweakDBID _attackRecordID;
		private TweakDBID _statusEffectOnDestroyID;

		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get => GetProperty(ref _isInternal);
			set => SetProperty(ref _isInternal, value);
		}

		[Ordinal(1)] 
		[RED("disableInteraction")] 
		public CBool DisableInteraction
		{
			get => GetProperty(ref _disableInteraction);
			set => SetProperty(ref _disableInteraction, value);
		}

		[Ordinal(2)] 
		[RED("destroyMesh")] 
		public CBool DestroyMesh
		{
			get => GetProperty(ref _destroyMesh);
			set => SetProperty(ref _destroyMesh, value);
		}

		[Ordinal(3)] 
		[RED("disableCollider")] 
		public CBool DisableCollider
		{
			get => GetProperty(ref _disableCollider);
			set => SetProperty(ref _disableCollider, value);
		}

		[Ordinal(4)] 
		[RED("hideMeshParameterValue")] 
		public CName HideMeshParameterValue
		{
			get => GetProperty(ref _hideMeshParameterValue);
			set => SetProperty(ref _hideMeshParameterValue, value);
		}

		[Ordinal(5)] 
		[RED("playHitFxFromOwnerEntity")] 
		public CBool PlayHitFxFromOwnerEntity
		{
			get => GetProperty(ref _playHitFxFromOwnerEntity);
			set => SetProperty(ref _playHitFxFromOwnerEntity, value);
		}

		[Ordinal(6)] 
		[RED("playDestroyedFxFromOwnerEntity")] 
		public CBool PlayDestroyedFxFromOwnerEntity
		{
			get => GetProperty(ref _playDestroyedFxFromOwnerEntity);
			set => SetProperty(ref _playDestroyedFxFromOwnerEntity, value);
		}

		[Ordinal(7)] 
		[RED("playBrokenFxFromOwnerEntity")] 
		public CBool PlayBrokenFxFromOwnerEntity
		{
			get => GetProperty(ref _playBrokenFxFromOwnerEntity);
			set => SetProperty(ref _playBrokenFxFromOwnerEntity, value);
		}

		[Ordinal(8)] 
		[RED("addFact")] 
		public CName AddFact
		{
			get => GetProperty(ref _addFact);
			set => SetProperty(ref _addFact, value);
		}

		[Ordinal(9)] 
		[RED("sendAIActionAnimFeatureName")] 
		public CName SendAIActionAnimFeatureName
		{
			get => GetProperty(ref _sendAIActionAnimFeatureName);
			set => SetProperty(ref _sendAIActionAnimFeatureName, value);
		}

		[Ordinal(10)] 
		[RED("sendAIActionAnimFeatureState")] 
		public CInt32 SendAIActionAnimFeatureState
		{
			get => GetProperty(ref _sendAIActionAnimFeatureState);
			set => SetProperty(ref _sendAIActionAnimFeatureState, value);
		}

		[Ordinal(11)] 
		[RED("destroyDelay")] 
		public CFloat DestroyDelay
		{
			get => GetProperty(ref _destroyDelay);
			set => SetProperty(ref _destroyDelay, value);
		}

		[Ordinal(12)] 
		[RED("useWeakspotDestroyStageVFX")] 
		public CBool UseWeakspotDestroyStageVFX
		{
			get => GetProperty(ref _useWeakspotDestroyStageVFX);
			set => SetProperty(ref _useWeakspotDestroyStageVFX, value);
		}

		[Ordinal(13)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get => GetProperty(ref _attackRecordID);
			set => SetProperty(ref _attackRecordID, value);
		}

		[Ordinal(14)] 
		[RED("StatusEffectOnDestroyID")] 
		public TweakDBID StatusEffectOnDestroyID
		{
			get => GetProperty(ref _statusEffectOnDestroyID);
			set => SetProperty(ref _statusEffectOnDestroyID, value);
		}

		public WeakspotOnDestroyProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
