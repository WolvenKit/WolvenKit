using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySoundEvent : MusicSettings
	{
		private CName _soundEvent;

		[Ordinal(1)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get
			{
				if (_soundEvent == null)
				{
					_soundEvent = (CName) CR2WTypeManager.Create("CName", "soundEvent", cr2w, this);
				}
				return _soundEvent;
			}
			set
			{
				if (_soundEvent == value)
				{
					return;
				}
				_soundEvent = value;
				PropertySet(this);
			}
		}

		public PlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
