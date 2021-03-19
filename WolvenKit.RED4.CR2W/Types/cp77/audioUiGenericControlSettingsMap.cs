using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiGenericControlSettingsMap : audioAudioMetadata
	{
		private CArray<audioUiGenericControlSettingsMapItem> _uiControlMatrix;

		[Ordinal(1)] 
		[RED("uiControlMatrix")] 
		public CArray<audioUiGenericControlSettingsMapItem> UiControlMatrix
		{
			get => GetProperty(ref _uiControlMatrix);
			set => SetProperty(ref _uiControlMatrix, value);
		}

		public audioUiGenericControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
