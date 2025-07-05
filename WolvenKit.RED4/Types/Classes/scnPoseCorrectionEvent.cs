using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPoseCorrectionEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetPropertyValue<animPoseCorrectionGroup>();
			set => SetPropertyValue<animPoseCorrectionGroup>(value);
		}

		public scnPoseCorrectionEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;
			PerformerId = new scnPerformerId { Id = 4294967040 };
			PoseCorrectionGroup = new animPoseCorrectionGroup { PoseCorrections = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
