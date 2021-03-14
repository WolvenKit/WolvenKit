using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGruntSettings : CVariable
	{
		private audioContextualVoiceGrunt _painShort;
		private audioContextualVoiceGrunt _effort;

		[Ordinal(0)] 
		[RED("painShort")] 
		public audioContextualVoiceGrunt PainShort
		{
			get
			{
				if (_painShort == null)
				{
					_painShort = (audioContextualVoiceGrunt) CR2WTypeManager.Create("audioContextualVoiceGrunt", "painShort", cr2w, this);
				}
				return _painShort;
			}
			set
			{
				if (_painShort == value)
				{
					return;
				}
				_painShort = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effort")] 
		public audioContextualVoiceGrunt Effort
		{
			get
			{
				if (_effort == null)
				{
					_effort = (audioContextualVoiceGrunt) CR2WTypeManager.Create("audioContextualVoiceGrunt", "effort", cr2w, this);
				}
				return _effort;
			}
			set
			{
				if (_effort == value)
				{
					return;
				}
				_effort = value;
				PropertySet(this);
			}
		}

		public audioContextualVoiceGruntSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
