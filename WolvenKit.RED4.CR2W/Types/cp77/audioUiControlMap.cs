using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiControlMap : audioAudioMetadata
	{
		private CHandle<audioKeyUiControlDictionary> _uiControlsByName;

		[Ordinal(1)] 
		[RED("uiControlsByName")] 
		public CHandle<audioKeyUiControlDictionary> UiControlsByName
		{
			get => GetProperty(ref _uiControlsByName);
			set => SetProperty(ref _uiControlsByName, value);
		}

		public audioUiControlMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
