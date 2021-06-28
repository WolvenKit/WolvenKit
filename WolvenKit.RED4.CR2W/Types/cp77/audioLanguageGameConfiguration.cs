using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLanguageGameConfiguration : audioAudioMetadata
	{
		private CArray<audioLanguageMapItem> _langsInProject;

		[Ordinal(1)] 
		[RED("langsInProject")] 
		public CArray<audioLanguageMapItem> LangsInProject
		{
			get => GetProperty(ref _langsInProject);
			set => SetProperty(ref _langsInProject, value);
		}

		public audioLanguageGameConfiguration(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
