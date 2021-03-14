using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaySoundEvent : inkanimEvent
	{
		private CName _soundEventName;

		[Ordinal(1)] 
		[RED("soundEventName")] 
		public CName SoundEventName
		{
			get
			{
				if (_soundEventName == null)
				{
					_soundEventName = (CName) CR2WTypeManager.Create("CName", "soundEventName", cr2w, this);
				}
				return _soundEventName;
			}
			set
			{
				if (_soundEventName == value)
				{
					return;
				}
				_soundEventName = value;
				PropertySet(this);
			}
		}

		public inkanimPlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
