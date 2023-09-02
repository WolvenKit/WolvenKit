using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LookAtController : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("E3_HACK_offset")] 
		public animVectorLink E3_HACK_offset
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(13)] 
		[RED("orderedBodyParts")] 
		public CArray<animLookAtPartInfo> OrderedBodyParts
		{
			get => GetPropertyValue<CArray<animLookAtPartInfo>>();
			set => SetPropertyValue<CArray<animLookAtPartInfo>>(value);
		}

		[Ordinal(14)] 
		[RED("stateMachinesSettings")] 
		public CArray<animLookAtStateMachineSettings> StateMachinesSettings
		{
			get => GetPropertyValue<CArray<animLookAtStateMachineSettings>>();
			set => SetPropertyValue<CArray<animLookAtStateMachineSettings>>(value);
		}

		[Ordinal(15)] 
		[RED("bodyPartsDependencies")] 
		public CArray<animLookAtPartsDependency> BodyPartsDependencies
		{
			get => GetPropertyValue<CArray<animLookAtPartsDependency>>();
			set => SetPropertyValue<CArray<animLookAtPartsDependency>>(value);
		}

		[Ordinal(16)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("isFacial")] 
		public CBool IsFacial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_LookAtController()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			E3_HACK_offset = new animVectorLink();
			OrderedBodyParts = new();
			StateMachinesSettings = new();
			BodyPartsDependencies = new();
			SubstepTime = 0.010000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
