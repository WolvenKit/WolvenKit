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
			get
			{
				if (_uiControlsByName == null)
				{
					_uiControlsByName = (CHandle<audioKeyUiControlDictionary>) CR2WTypeManager.Create("handle:audioKeyUiControlDictionary", "uiControlsByName", cr2w, this);
				}
				return _uiControlsByName;
			}
			set
			{
				if (_uiControlsByName == value)
				{
					return;
				}
				_uiControlsByName = value;
				PropertySet(this);
			}
		}

		public audioUiControlMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
