using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDamageRequest : gameScriptableSystemRequest
	{
		private CBool _isInternal;
		private CFloat _damagePercentValue;
		private entEntityID _targetID;
		private Vector4 _targetPosition;

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
		[RED("damagePercentValue")] 
		public CFloat DamagePercentValue
		{
			get
			{
				if (_damagePercentValue == null)
				{
					_damagePercentValue = (CFloat) CR2WTypeManager.Create("Float", "damagePercentValue", cr2w, this);
				}
				return _damagePercentValue;
			}
			set
			{
				if (_damagePercentValue == value)
				{
					return;
				}
				_damagePercentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		public PreventionDamageRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
