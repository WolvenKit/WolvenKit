using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagAppearanceMapping : audioAudioMetadata
	{
		private CArray<audioVoiceTagAppearanceGroup> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<audioVoiceTagAppearanceGroup> Mappings
		{
			get
			{
				if (_mappings == null)
				{
					_mappings = (CArray<audioVoiceTagAppearanceGroup>) CR2WTypeManager.Create("array:audioVoiceTagAppearanceGroup", "mappings", cr2w, this);
				}
				return _mappings;
			}
			set
			{
				if (_mappings == value)
				{
					return;
				}
				_mappings = value;
				PropertySet(this);
			}
		}

		public audioVoiceTagAppearanceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
