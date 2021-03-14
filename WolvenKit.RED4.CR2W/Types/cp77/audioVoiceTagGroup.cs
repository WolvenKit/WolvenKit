using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagGroup : audioAudioMetadata
	{
		private CArray<CName> _voiceTags;

		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<CName> VoiceTags
		{
			get
			{
				if (_voiceTags == null)
				{
					_voiceTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "voiceTags", cr2w, this);
				}
				return _voiceTags;
			}
			set
			{
				if (_voiceTags == value)
				{
					return;
				}
				_voiceTags = value;
				PropertySet(this);
			}
		}

		public audioVoiceTagGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
