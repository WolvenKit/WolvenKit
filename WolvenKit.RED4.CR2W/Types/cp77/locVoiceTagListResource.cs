using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoiceTagListResource : CResource
	{
		private CArray<locVoiceTag> _voiceTags;

		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<locVoiceTag> VoiceTags
		{
			get
			{
				if (_voiceTags == null)
				{
					_voiceTags = (CArray<locVoiceTag>) CR2WTypeManager.Create("array:locVoiceTag", "voiceTags", cr2w, this);
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

		public locVoiceTagListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
