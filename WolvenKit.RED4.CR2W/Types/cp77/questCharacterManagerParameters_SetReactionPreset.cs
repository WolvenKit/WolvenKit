using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetReactionPreset : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CHandle<questReactionPresetRecordSelector> _recordSelector;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("recordSelector")] 
		public CHandle<questReactionPresetRecordSelector> RecordSelector
		{
			get => GetProperty(ref _recordSelector);
			set => SetProperty(ref _recordSelector, value);
		}

		public questCharacterManagerParameters_SetReactionPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
