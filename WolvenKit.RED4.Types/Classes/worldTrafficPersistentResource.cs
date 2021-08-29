using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentResource : resStreamedResource
	{
		private worldTrafficPersistentData _data;

		[Ordinal(1)] 
		[RED("data")] 
		public worldTrafficPersistentData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
