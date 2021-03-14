using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMap : audioAudioMetadata
	{
		private CArray<audioUiSpecificControlSettingsMapItem> _specificControlSettingsMatrix;

		[Ordinal(1)] 
		[RED("specificControlSettingsMatrix")] 
		public CArray<audioUiSpecificControlSettingsMapItem> SpecificControlSettingsMatrix
		{
			get
			{
				if (_specificControlSettingsMatrix == null)
				{
					_specificControlSettingsMatrix = (CArray<audioUiSpecificControlSettingsMapItem>) CR2WTypeManager.Create("array:audioUiSpecificControlSettingsMapItem", "specificControlSettingsMatrix", cr2w, this);
				}
				return _specificControlSettingsMatrix;
			}
			set
			{
				if (_specificControlSettingsMatrix == value)
				{
					return;
				}
				_specificControlSettingsMatrix = value;
				PropertySet(this);
			}
		}

		public audioUiSpecificControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
