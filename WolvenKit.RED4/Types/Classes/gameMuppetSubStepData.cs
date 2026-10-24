using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetSubStepData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("parentFrameId")] 
		public CUInt32 ParentFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("parentFramePrimaryColor")] 
		public CBool ParentFramePrimaryColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("inputState")] 
		public gameMuppetInputState InputState
		{
			get => GetPropertyValue<gameMuppetInputState>();
			set => SetPropertyValue<gameMuppetInputState>(value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetPropertyValue<gameMuppetState>();
			set => SetPropertyValue<gameMuppetState>(value);
		}

		[Ordinal(5)] 
		[RED("resimulationSubsteps")] 
		public CArray<gameMuppetSubStepData> ResimulationSubsteps
		{
			get => GetPropertyValue<CArray<gameMuppetSubStepData>>();
			set => SetPropertyValue<CArray<gameMuppetSubStepData>>(value);
		}

		public gameMuppetSubStepData()
		{
			InputState = new gameMuppetInputState();
			State = new gameMuppetState();
			ResimulationSubsteps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
