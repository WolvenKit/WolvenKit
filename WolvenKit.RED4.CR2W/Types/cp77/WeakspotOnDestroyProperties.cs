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
		private TweakDBID _attackRecordID;
		private TweakDBID _statusEffectOnDestroyID;

		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get
			{
				if (_isInternal == null)
				{
					_isInternal = (CBool) CR2WTypeManager.Create("Bool", "isInternal", cr2w, this);
				}
				return _isInternal;
			}
			set
			{
				if (_isInternal == value)
				{
					return;
				}
				_isInternal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disableInteraction")] 
		public CBool DisableInteraction
		{
			get
			{
				if (_disableInteraction == null)
				{
					_disableInteraction = (CBool) CR2WTypeManager.Create("Bool", "disableInteraction", cr2w, this);
				}
				return _disableInteraction;
			}
			set
			{
				if (_disableInteraction == value)
				{
					return;
				}
				_disableInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destroyMesh")] 
		public CBool DestroyMesh
		{
			get
			{
				if (_destroyMesh == null)
				{
					_destroyMesh = (CBool) CR2WTypeManager.Create("Bool", "destroyMesh", cr2w, this);
				}
				return _destroyMesh;
			}
			set
			{
				if (_destroyMesh == value)
				{
					return;
				}
				_destroyMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("disableCollider")] 
		public CBool DisableCollider
		{
			get
			{
				if (_disableCollider == null)
				{
					_disableCollider = (CBool) CR2WTypeManager.Create("Bool", "disableCollider", cr2w, this);
				}
				return _disableCollider;
			}
			set
			{
				if (_disableCollider == value)
				{
					return;
				}
				_disableCollider = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hideMeshParameterValue")] 
		public CName HideMeshParameterValue
		{
			get
			{
				if (_hideMeshParameterValue == null)
				{
					_hideMeshParameterValue = (CName) CR2WTypeManager.Create("CName", "hideMeshParameterValue", cr2w, this);
				}
				return _hideMeshParameterValue;
			}
			set
			{
				if (_hideMeshParameterValue == value)
				{
					return;
				}
				_hideMeshParameterValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playHitFxFromOwnerEntity")] 
		public CBool PlayHitFxFromOwnerEntity
		{
			get
			{
				if (_playHitFxFromOwnerEntity == null)
				{
					_playHitFxFromOwnerEntity = (CBool) CR2WTypeManager.Create("Bool", "playHitFxFromOwnerEntity", cr2w, this);
				}
				return _playHitFxFromOwnerEntity;
			}
			set
			{
				if (_playHitFxFromOwnerEntity == value)
				{
					return;
				}
				_playHitFxFromOwnerEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playDestroyedFxFromOwnerEntity")] 
		public CBool PlayDestroyedFxFromOwnerEntity
		{
			get
			{
				if (_playDestroyedFxFromOwnerEntity == null)
				{
					_playDestroyedFxFromOwnerEntity = (CBool) CR2WTypeManager.Create("Bool", "playDestroyedFxFromOwnerEntity", cr2w, this);
				}
				return _playDestroyedFxFromOwnerEntity;
			}
			set
			{
				if (_playDestroyedFxFromOwnerEntity == value)
				{
					return;
				}
				_playDestroyedFxFromOwnerEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playBrokenFxFromOwnerEntity")] 
		public CBool PlayBrokenFxFromOwnerEntity
		{
			get
			{
				if (_playBrokenFxFromOwnerEntity == null)
				{
					_playBrokenFxFromOwnerEntity = (CBool) CR2WTypeManager.Create("Bool", "playBrokenFxFromOwnerEntity", cr2w, this);
				}
				return _playBrokenFxFromOwnerEntity;
			}
			set
			{
				if (_playBrokenFxFromOwnerEntity == value)
				{
					return;
				}
				_playBrokenFxFromOwnerEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("addFact")] 
		public CName AddFact
		{
			get
			{
				if (_addFact == null)
				{
					_addFact = (CName) CR2WTypeManager.Create("CName", "addFact", cr2w, this);
				}
				return _addFact;
			}
			set
			{
				if (_addFact == value)
				{
					return;
				}
				_addFact = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("sendAIActionAnimFeatureName")] 
		public CName SendAIActionAnimFeatureName
		{
			get
			{
				if (_sendAIActionAnimFeatureName == null)
				{
					_sendAIActionAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "sendAIActionAnimFeatureName", cr2w, this);
				}
				return _sendAIActionAnimFeatureName;
			}
			set
			{
				if (_sendAIActionAnimFeatureName == value)
				{
					return;
				}
				_sendAIActionAnimFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sendAIActionAnimFeatureState")] 
		public CInt32 SendAIActionAnimFeatureState
		{
			get
			{
				if (_sendAIActionAnimFeatureState == null)
				{
					_sendAIActionAnimFeatureState = (CInt32) CR2WTypeManager.Create("Int32", "sendAIActionAnimFeatureState", cr2w, this);
				}
				return _sendAIActionAnimFeatureState;
			}
			set
			{
				if (_sendAIActionAnimFeatureState == value)
				{
					return;
				}
				_sendAIActionAnimFeatureState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("destroyDelay")] 
		public CFloat DestroyDelay
		{
			get
			{
				if (_destroyDelay == null)
				{
					_destroyDelay = (CFloat) CR2WTypeManager.Create("Float", "destroyDelay", cr2w, this);
				}
				return _destroyDelay;
			}
			set
			{
				if (_destroyDelay == value)
				{
					return;
				}
				_destroyDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get
			{
				if (_attackRecordID == null)
				{
					_attackRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackRecordID", cr2w, this);
				}
				return _attackRecordID;
			}
			set
			{
				if (_attackRecordID == value)
				{
					return;
				}
				_attackRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("StatusEffectOnDestroyID")] 
		public TweakDBID StatusEffectOnDestroyID
		{
			get
			{
				if (_statusEffectOnDestroyID == null)
				{
					_statusEffectOnDestroyID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "StatusEffectOnDestroyID", cr2w, this);
				}
				return _statusEffectOnDestroyID;
			}
			set
			{
				if (_statusEffectOnDestroyID == value)
				{
					return;
				}
				_statusEffectOnDestroyID = value;
				PropertySet(this);
			}
		}

		public WeakspotOnDestroyProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
