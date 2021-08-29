using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		private CArray<audioAudBulletTimeModeMapItem> _bulletTimeMapItems;

		[Ordinal(1)] 
		[RED("bulletTimeMapItems")] 
		public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems
		{
			get => GetProperty(ref _bulletTimeMapItems);
			set => SetProperty(ref _bulletTimeMapItems, value);
		}
	}
}
