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
			get
			{
				if (_bulletTimeMapItems == null)
				{
					_bulletTimeMapItems = (CArray<audioAudBulletTimeModeMapItem>) CR2WTypeManager.Create("array:audioAudBulletTimeModeMapItem", "bulletTimeMapItems", cr2w, this);
				}
				return _bulletTimeMapItems;
			}
			set
			{
				if (_bulletTimeMapItems == value)
				{
					return;
				}
				_bulletTimeMapItems = value;
				PropertySet(this);
			}
		}

		public audioAudBulletTimeModeMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
