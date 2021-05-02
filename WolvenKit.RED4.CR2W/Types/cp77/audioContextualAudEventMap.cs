using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMap : audioAudioMetadata
	{
		private CArray<audioContextualAudEventMapItem> _contextualAudEventMapItems;

		[Ordinal(1)] 
		[RED("contextualAudEventMapItems")] 
		public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems
		{
			get => GetProperty(ref _contextualAudEventMapItems);
			set => SetProperty(ref _contextualAudEventMapItems, value);
		}

		public audioContextualAudEventMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
