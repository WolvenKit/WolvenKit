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
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;
			IkData = new scnIKEventData { Orientation = new Quaternion { R = 1.000000F }, Basic = new scnAnimTargetBasicData { PerformerId = new scnPerformerId { Id = 4294967040 }, IsStart = true, TargetPerformerId = new scnPerformerId { Id = 4294967040 }, TargetSlot = "pla_default_tgt", TargetOffsetEntitySpace = new Vector4(), StaticTarget = new Vector4 { W = 1.000000F }, TargetActorId = new scnActorId { Id = uint.MaxValue }, TargetPropId = new scnPropId { Id = uint.MaxValue } }, ChainName = "ikRightArm", Request = new animIKTargetRequest { WeightPosition = 1.000000F, WeightOrientation = 1.000000F, TransitionIn = 0.300000F, TransitionOut = 0.300000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
