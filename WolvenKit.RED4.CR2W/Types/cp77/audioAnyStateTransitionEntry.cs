using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAnyStateTransitionEntry : CVariable
	{
		private CBool _isDisabled;
		private CUInt8 _sourceStateId;
		private CUInt8 _targetStateId;
		private CFloat _transitionTime;

		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get
			{
				if (_isDisabled == null)
				{
					_isDisabled = (CBool) CR2WTypeManager.Create("Bool", "isDisabled", cr2w, this);
				}
				return _isDisabled;
			}
			set
			{
				if (_isDisabled == value)
				{
					return;
				}
				_isDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sourceStateId")] 
		public CUInt8 SourceStateId
		{
			get
			{
				if (_sourceStateId == null)
				{
					_sourceStateId = (CUInt8) CR2WTypeManager.Create("Uint8", "sourceStateId", cr2w, this);
				}
				return _sourceStateId;
			}
			set
			{
				if (_sourceStateId == value)
				{
					return;
				}
				_sourceStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get
			{
				if (_targetStateId == null)
				{
					_targetStateId = (CUInt8) CR2WTypeManager.Create("Uint8", "targetStateId", cr2w, this);
				}
				return _targetStateId;
			}
			set
			{
				if (_targetStateId == value)
				{
					return;
				}
				_targetStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get
			{
				if (_transitionTime == null)
				{
					_transitionTime = (CFloat) CR2WTypeManager.Create("Float", "transitionTime", cr2w, this);
				}
				return _transitionTime;
			}
			set
			{
				if (_transitionTime == value)
				{
					return;
				}
				_transitionTime = value;
				PropertySet(this);
			}
		}

		public audioAnyStateTransitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
