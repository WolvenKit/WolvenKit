using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GateSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<AISignalSenderTask> Data
		{
			get => GetPropertyValue<CHandle<AISignalSenderTask>>();
			set => SetPropertyValue<CHandle<AISignalSenderTask>>(value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GateSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
