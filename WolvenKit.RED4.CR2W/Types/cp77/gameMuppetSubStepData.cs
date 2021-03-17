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
			get => GetProperty(ref _frameId);
			set => SetProperty(ref _frameId, value);
		}

		[Ordinal(1)] 
		[RED("parentFrameId")] 
		public CUInt32 ParentFrameId
		{
			get => GetProperty(ref _parentFrameId);
			set => SetProperty(ref _parentFrameId, value);
		}

		[Ordinal(2)] 
		[RED("parentFramePrimaryColor")] 
		public CBool ParentFramePrimaryColor
		{
			get => GetProperty(ref _parentFramePrimaryColor);
			set => SetProperty(ref _parentFramePrimaryColor, value);
		}

		[Ordinal(3)] 
		[RED("inputState")] 
		public gameMuppetInputState InputState
		{
			get => GetProperty(ref _inputState);
			set => SetProperty(ref _inputState, value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(5)] 
		[RED("resimulationSubsteps")] 
		public CArray<gameMuppetSubStepData> ResimulationSubsteps
		{
			get => GetProperty(ref _resimulationSubsteps);
			set => SetProperty(ref _resimulationSubsteps, value);
		}

		public gameMuppetSubStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
