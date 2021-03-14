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
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isStart")] 
		public CBool IsStart
		{
			get
			{
				if (_isStart == null)
				{
					_isStart = (CBool) CR2WTypeManager.Create("Bool", "isStart", cr2w, this);
				}
				return _isStart;
			}
			set
			{
				if (_isStart == value)
				{
					return;
				}
				_isStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetPerformerId")] 
		public scnPerformerId TargetPerformerId
		{
			get
			{
				if (_targetPerformerId == null)
				{
					_targetPerformerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "targetPerformerId", cr2w, this);
				}
				return _targetPerformerId;
			}
			set
			{
				if (_targetPerformerId == value)
				{
					return;
				}
				_targetPerformerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get
			{
				if (_targetSlot == null)
				{
					_targetSlot = (CName) CR2WTypeManager.Create("CName", "targetSlot", cr2w, this);
				}
				return _targetSlot;
			}
			set
			{
				if (_targetSlot == value)
				{
					return;
				}
				_targetSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetOffsetEntitySpace")] 
		public Vector4 TargetOffsetEntitySpace
		{
			get
			{
				if (_targetOffsetEntitySpace == null)
				{
					_targetOffsetEntitySpace = (Vector4) CR2WTypeManager.Create("Vector4", "targetOffsetEntitySpace", cr2w, this);
				}
				return _targetOffsetEntitySpace;
			}
			set
			{
				if (_targetOffsetEntitySpace == value)
				{
					return;
				}
				_targetOffsetEntitySpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("staticTarget")] 
		public Vector4 StaticTarget
		{
			get
			{
				if (_staticTarget == null)
				{
					_staticTarget = (Vector4) CR2WTypeManager.Create("Vector4", "staticTarget", cr2w, this);
				}
				return _staticTarget;
			}
			set
			{
				if (_staticTarget == value)
				{
					return;
				}
				_staticTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetActorId")] 
		public scnActorId TargetActorId
		{
			get
			{
				if (_targetActorId == null)
				{
					_targetActorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "targetActorId", cr2w, this);
				}
				return _targetActorId;
			}
			set
			{
				if (_targetActorId == value)
				{
					return;
				}
				_targetActorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetPropId")] 
		public scnPropId TargetPropId
		{
			get
			{
				if (_targetPropId == null)
				{
					_targetPropId = (scnPropId) CR2WTypeManager.Create("scnPropId", "targetPropId", cr2w, this);
				}
				return _targetPropId;
			}
			set
			{
				if (_targetPropId == value)
				{
					return;
				}
				_targetPropId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("targetType")] 
		public CEnum<scnLookAtTargetType> TargetType
		{
			get
			{
				if (_targetType == null)
				{
					_targetType = (CEnum<scnLookAtTargetType>) CR2WTypeManager.Create("scnLookAtTargetType", "targetType", cr2w, this);
				}
				return _targetType;
			}
			set
			{
				if (_targetType == value)
				{
					return;
				}
				_targetType = value;
				PropertySet(this);
			}
		}

		public scnAnimTargetBasicData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
