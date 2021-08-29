using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTaskProgressMessage : RedBaseClass
	{
		private CUInt32 _id;
		private CFloat _progress;
		private CFloat _processingTime;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(2)] 
		[RED("processingTime")] 
		public CFloat ProcessingTime
		{
			get => GetProperty(ref _processingTime);
			set => SetProperty(ref _processingTime, value);
		}
	}
}
