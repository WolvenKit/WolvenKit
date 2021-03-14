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
			get
			{
				if (_uiControlMatrix == null)
				{
					_uiControlMatrix = (CArray<audioUiGenericControlSettingsMapItem>) CR2WTypeManager.Create("array:audioUiGenericControlSettingsMapItem", "uiControlMatrix", cr2w, this);
				}
				return _uiControlMatrix;
			}
			set
			{
				if (_uiControlMatrix == value)
				{
					return;
				}
				_uiControlMatrix = value;
				PropertySet(this);
			}
		}

		public audioUiGenericControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
