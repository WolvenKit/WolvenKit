using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigMap : audioAudioMetadata
	{
		private CArray<audioMeleeRigMapItem> _mapItems;

		[Ordinal(1)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigMapItem> MapItems
		{
			get => GetProperty(ref _mapItems);
			set => SetProperty(ref _mapItems, value);
		}

		public audioMeleeRigMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
