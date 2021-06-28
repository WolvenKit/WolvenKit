using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootwearType : audioAudioMetadata
	{
		private CArray<CName> _itemNames;

		[Ordinal(1)] 
		[RED("itemNames")] 
		public CArray<CName> ItemNames
		{
			get => GetProperty(ref _itemNames);
			set => SetProperty(ref _itemNames, value);
		}

		public audioFootwearType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
