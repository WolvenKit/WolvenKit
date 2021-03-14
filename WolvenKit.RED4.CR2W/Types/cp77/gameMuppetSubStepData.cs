using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetSubStepData : CVariable
	{
		private CUInt32 _frameId;
		private CUInt32 _parentFrameId;
		private CBool _parentFramePrimaryColor;
		private gameMuppetInputState _inputState;
		private gameMuppetState _state;
		private CArray<gameMuppetSubStepData> _resimulationSubsteps;

		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get
			{
				if (_frameId == null)
				{
					_frameId = (CUInt32) CR2WTypeManager.Create("Uint32", "frameId", cr2w, this);
				}
				return _frameId;
			}
			set
			{
				if (_frameId == value)
				{
					return;
				}
				_frameId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentFrameId")] 
		public CUInt32 ParentFrameId
		{
			get
			{
				if (_parentFrameId == null)
				{
					_parentFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "parentFrameId", cr2w, this);
				}
				return _parentFrameId;
			}
			set
			{
				if (_parentFrameId == value)
				{
					return;
				}
				_parentFrameId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentFramePrimaryColor")] 
		public CBool ParentFramePrimaryColor
		{
			get
			{
				if (_parentFramePrimaryColor == null)
				{
					_parentFramePrimaryColor = (CBool) CR2WTypeManager.Create("Bool", "parentFramePrimaryColor", cr2w, this);
				}
				return _parentFramePrimaryColor;
			}
			set
			{
				if (_parentFramePrimaryColor == value)
				{
					return;
				}
				_parentFramePrimaryColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputState")] 
		public gameMuppetInputState InputState
		{
			get
			{
				if (_inputState == null)
				{
					_inputState = (gameMuppetInputState) CR2WTypeManager.Create("gameMuppetInputState", "inputState", cr2w, this);
				}
				return _inputState;
			}
			set
			{
				if (_inputState == value)
				{
					return;
				}
				_inputState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get
			{
				if (_state == null)
				{
					_state = (gameMuppetState) CR2WTypeManager.Create("gameMuppetState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("resimulationSubsteps")] 
		public CArray<gameMuppetSubStepData> ResimulationSubsteps
		{
			get
			{
				if (_resimulationSubsteps == null)
				{
					_resimulationSubsteps = (CArray<gameMuppetSubStepData>) CR2WTypeManager.Create("array:gameMuppetSubStepData", "resimulationSubsteps", cr2w, this);
				}
				return _resimulationSubsteps;
			}
			set
			{
				if (_resimulationSubsteps == value)
				{
					return;
				}
				_resimulationSubsteps = value;
				PropertySet(this);
			}
		}

		public gameMuppetSubStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
