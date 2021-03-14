using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopSound : redEvent
	{
		private CName _soundName;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get
			{
				if (_soundName == null)
				{
					_soundName = (CName) CR2WTypeManager.Create("CName", "soundName", cr2w, this);
				}
				return _soundName;
			}
			set
			{
				if (_soundName == value)
				{
					return;
				}
				_soundName = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsStopSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
