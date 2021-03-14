using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entInjectVoiceTagEvent : redEvent
	{
		private CName _voiceTagName;
		private CBool _forceInjection;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get
			{
				if (_voiceTagName == null)
				{
					_voiceTagName = (CName) CR2WTypeManager.Create("CName", "voiceTagName", cr2w, this);
				}
				return _voiceTagName;
			}
			set
			{
				if (_voiceTagName == value)
				{
					return;
				}
				_voiceTagName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceInjection")] 
		public CBool ForceInjection
		{
			get
			{
				if (_forceInjection == null)
				{
					_forceInjection = (CBool) CR2WTypeManager.Create("Bool", "forceInjection", cr2w, this);
				}
				return _forceInjection;
			}
			set
			{
				if (_forceInjection == value)
				{
					return;
				}
				_forceInjection = value;
				PropertySet(this);
			}
		}

		public entInjectVoiceTagEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
