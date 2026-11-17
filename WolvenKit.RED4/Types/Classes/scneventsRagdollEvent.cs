using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsRagdollEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("enableRagdoll")] 
		public CBool EnableRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsRagdollEvent()
		{
			Id = new scnSceneEventId();
			Performer = new scnPerformerId();
			EnableRagdoll = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
