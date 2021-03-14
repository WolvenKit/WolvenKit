using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimAdjuster : animAnimNode_SkAnim
	{
		private animVectorLink _targetPositionWs;
		private animVectorLink _targetDirectionWs;
		private Vector4 _initialForwardVector;
		private CName _startAdjustmentEventName;
		private CName _endAdjustmentEventName;

		[Ordinal(30)] 
		[RED("targetPositionWs")] 
		public animVectorLink TargetPositionWs
		{
			get
			{
				if (_targetPositionWs == null)
				{
					_targetPositionWs = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetPositionWs", cr2w, this);
				}
				return _targetPositionWs;
			}
			set
			{
				if (_targetPositionWs == value)
				{
					return;
				}
				_targetPositionWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("targetDirectionWs")] 
		public animVectorLink TargetDirectionWs
		{
			get
			{
				if (_targetDirectionWs == null)
				{
					_targetDirectionWs = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetDirectionWs", cr2w, this);
				}
				return _targetDirectionWs;
			}
			set
			{
				if (_targetDirectionWs == value)
				{
					return;
				}
				_targetDirectionWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get
			{
				if (_initialForwardVector == null)
				{
					_initialForwardVector = (Vector4) CR2WTypeManager.Create("Vector4", "initialForwardVector", cr2w, this);
				}
				return _initialForwardVector;
			}
			set
			{
				if (_initialForwardVector == value)
				{
					return;
				}
				_initialForwardVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("startAdjustmentEventName")] 
		public CName StartAdjustmentEventName
		{
			get
			{
				if (_startAdjustmentEventName == null)
				{
					_startAdjustmentEventName = (CName) CR2WTypeManager.Create("CName", "startAdjustmentEventName", cr2w, this);
				}
				return _startAdjustmentEventName;
			}
			set
			{
				if (_startAdjustmentEventName == value)
				{
					return;
				}
				_startAdjustmentEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("endAdjustmentEventName")] 
		public CName EndAdjustmentEventName
		{
			get
			{
				if (_endAdjustmentEventName == null)
				{
					_endAdjustmentEventName = (CName) CR2WTypeManager.Create("CName", "endAdjustmentEventName", cr2w, this);
				}
				return _endAdjustmentEventName;
			}
			set
			{
				if (_endAdjustmentEventName == value)
				{
					return;
				}
				_endAdjustmentEventName = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkAnimAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
