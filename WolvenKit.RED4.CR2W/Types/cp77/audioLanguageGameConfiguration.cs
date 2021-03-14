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
			get
			{
				if (_langsInProject == null)
				{
					_langsInProject = (CArray<audioLanguageMapItem>) CR2WTypeManager.Create("array:audioLanguageMapItem", "langsInProject", cr2w, this);
				}
				return _langsInProject;
			}
			set
			{
				if (_langsInProject == value)
				{
					return;
				}
				_langsInProject = value;
				PropertySet(this);
			}
		}

		public audioLanguageGameConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
