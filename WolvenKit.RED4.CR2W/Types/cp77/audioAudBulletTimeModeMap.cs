using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		private CArray<audioAudBulletTimeModeMapItem> _bulletTimeMapItems;

		[Ordinal(1)] 
		[RED("bulletTimeMapItems")] 
		public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems
		{
			get => GetProperty(ref _bulletTimeMapItems);
			set => SetProperty(ref _bulletTimeMapItems, value);
		}

		public audioAudBulletTimeModeMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
