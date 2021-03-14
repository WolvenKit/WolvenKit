using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterHit_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _attackerRef;
		private CBool _isAttackerPlayer;
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
			get
			{
				if (_attackerRef == null)
				{
					_attackerRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "attackerRef", cr2w, this);
				}
				return _attackerRef;
			}
			set
			{
				if (_attackerRef == value)
				{
					return;
				}
				_attackerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAttackerPlayer")] 
		public CBool IsAttackerPlayer
		{
			get
			{
				if (_isAttackerPlayer == null)
				{
					_isAttackerPlayer = (CBool) CR2WTypeManager.Create("Bool", "isAttackerPlayer", cr2w, this);
				}
				return _isAttackerPlayer;
			}
			set
			{
				if (_isAttackerPlayer == value)
				{
					return;
				}
				_isAttackerPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get
			{
				if (_isTargetPlayer == null)
				{
					_isTargetPlayer = (CBool) CR2WTypeManager.Create("Bool", "isTargetPlayer", cr2w, this);
				}
				return _isTargetPlayer;
			}
			set
			{
				if (_isTargetPlayer == value)
				{
					return;
				}
				_isTargetPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("includeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> IncludeHitTypes
		{
			get
			{
				if (_includeHitTypes == null)
				{
					_includeHitTypes = (CArray<CEnum<questCharacterHitEventType>>) CR2WTypeManager.Create("array:questCharacterHitEventType", "includeHitTypes", cr2w, this);
				}
				return _includeHitTypes;
			}
			set
			{
				if (_includeHitTypes == value)
				{
					return;
				}
				_includeHitTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("excludeHitTypes")] 
		public CArray<CEnum<questCharacterHitEventType>> ExcludeHitTypes
		{
			get
			{
				if (_excludeHitTypes == null)
				{
					_excludeHitTypes = (CArray<CEnum<questCharacterHitEventType>>) CR2WTypeManager.Create("array:questCharacterHitEventType", "excludeHitTypes", cr2w, this);
				}
				return _excludeHitTypes;
			}
			set
			{
				if (_excludeHitTypes == value)
				{
					return;
				}
				_excludeHitTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("includeHitShapes")] 
		public CArray<CName> IncludeHitShapes
		{
			get
			{
				if (_includeHitShapes == null)
				{
					_includeHitShapes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "includeHitShapes", cr2w, this);
				}
				return _includeHitShapes;
			}
			set
			{
				if (_includeHitShapes == value)
				{
					return;
				}
				_includeHitShapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("excludeHitShapes")] 
		public CArray<CName> ExcludeHitShapes
		{
			get
			{
				if (_excludeHitShapes == null)
				{
					_excludeHitShapes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "excludeHitShapes", cr2w, this);
				}
				return _excludeHitShapes;
			}
			set
			{
				if (_excludeHitShapes == value)
				{
					return;
				}
				_excludeHitShapes = value;
				PropertySet(this);
			}
		}

		public questCharacterHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
