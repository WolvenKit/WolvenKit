using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnIKEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("orientation")] 
		public Quaternion Orientation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(1)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(2)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get => GetPropertyValue<animIKTargetRequest>();
			set => SetPropertyValue<animIKTargetRequest>(value);
		}

		public scnIKEventData()
		{
			Orientation = new() { R = 1.000000F };
			Basic = new() { PerformerId = new() { Id = 4294967040 }, IsStart = true, TargetPerformerId = new() { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new(), StaticTarget = new() { W = 1.000000F }, TargetActorId = new() { Id = 4294967295 }, TargetPropId = new() { Id = 4294967295 } };
			ChainName = "ikRightArm";
			Request = new() { WeightPosition = 1.000000F, WeightOrientation = 1.000000F, TransitionIn = 0.300000F, TransitionOut = 0.300000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
