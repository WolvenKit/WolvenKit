using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIGateSignal : RedBaseClass
	{
		private CStatic<CName> _tags;
		private CEnum<AISignalFlags> _flags;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(0)] 
		[RED("tags", 4)] 
		public CStatic<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<AISignalFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
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

		public AIGateSignal()
		{
			_priority = 1.000000F;
		}
	}
}
