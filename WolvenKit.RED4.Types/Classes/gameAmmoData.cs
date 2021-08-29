using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAmmoData : RedBaseClass
	{
		private gameItemID _id;
		private CInt32 _available;
		private CInt32 _equipped;

		[Ordinal(0)] 
		[RED("id")] 
		public gameItemID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("available")] 
		public CInt32 Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}

		[Ordinal(2)] 
		[RED("equipped")] 
		public CInt32 Equipped
		{
			get => GetProperty(ref _equipped);
			set => SetProperty(ref _equipped, value);
		}
	}
}
