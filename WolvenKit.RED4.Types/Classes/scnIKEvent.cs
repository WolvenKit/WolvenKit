using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnIKEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("ikData")] 
		public scnIKEventData IkData
		{
			get => GetPropertyValue<scnIKEventData>();
			set => SetPropertyValue<scnIKEventData>(value);
		}

		public scnIKEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Duration = 1000;
			IkData = new() { Orientation = new() { R = 1.000000F }, Basic = new() { PerformerId = new() { Id = 4294967040 }, IsStart = true, TargetPerformerId = new() { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new(), StaticTarget = new() { W = 1.000000F }, TargetActorId = new() { Id = 4294967295 }, TargetPropId = new() { Id = 4294967295 } }, ChainName = "ikRightArm", Request = new() { WeightPosition = 1.000000F, WeightOrientation = 1.000000F, TransitionIn = 0.300000F, TransitionOut = 0.300000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
