using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceTriggerRewireMapItem> _items;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<audioVoiceTriggerRewireMapItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public audioVoiceTriggerRewireMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
