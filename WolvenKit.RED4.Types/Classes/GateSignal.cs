using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GateSignal : gameTaggedSignalUserData
	{
		private CHandle<AISignalSenderTask> _data;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<AISignalSenderTask> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(3)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetProperty(ref _lifeTime);
			set => SetProperty(ref _lifeTime, value);
		}
	}
}
