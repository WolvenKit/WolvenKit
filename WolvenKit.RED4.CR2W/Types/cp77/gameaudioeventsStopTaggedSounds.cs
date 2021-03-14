using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopTaggedSounds : redEvent
	{
		private CName _audioTag;

		[Ordinal(0)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get
			{
				if (_audioTag == null)
				{
					_audioTag = (CName) CR2WTypeManager.Create("CName", "audioTag", cr2w, this);
				}
				return _audioTag;
			}
			set
			{
				if (_audioTag == value)
				{
					return;
				}
				_audioTag = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsStopTaggedSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
