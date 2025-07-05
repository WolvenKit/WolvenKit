using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedAchivementCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dataTrackingSystem")] 
		public CHandle<DataTrackingSystem> DataTrackingSystem
		{
			get => GetPropertyValue<CHandle<DataTrackingSystem>>();
			set => SetPropertyValue<CHandle<DataTrackingSystem>>(value);
		}

		public DelayedAchivementCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
