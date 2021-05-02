using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleMapEntry : CVariable
	{
		private CName _subtitleGroup;
		private raRef<JsonResource> _subtitleFile;

		[Ordinal(0)] 
		[RED("subtitleGroup")] 
		public CName SubtitleGroup
		{
			get => GetProperty(ref _subtitleGroup);
			set => SetProperty(ref _subtitleGroup, value);
		}

		[Ordinal(1)] 
		[RED("subtitleFile")] 
		public raRef<JsonResource> SubtitleFile
		{
			get => GetProperty(ref _subtitleFile);
			set => SetProperty(ref _subtitleFile, value);
		}

		public localizationPersistenceSubtitleMapEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
