using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsRevealObjectEvent : redEvent
	{
		private CBool _reveal;
		private gameVisionModeSystemRevealIdentifier _reason;
		private CFloat _lifetime;

		[Ordinal(0)] 
		[RED("reveal")] 
		public CBool Reveal
		{
			get
			{
				if (_reveal == null)
				{
					_reveal = (CBool) CR2WTypeManager.Create("Bool", "reveal", cr2w, this);
				}
				return _reveal;
			}
			set
			{
				if (_reveal == value)
				{
					return;
				}
				_reveal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public gameVisionModeSystemRevealIdentifier Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (gameVisionModeSystemRevealIdentifier) CR2WTypeManager.Create("gameVisionModeSystemRevealIdentifier", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get
			{
				if (_lifetime == null)
				{
					_lifetime = (CFloat) CR2WTypeManager.Create("Float", "lifetime", cr2w, this);
				}
				return _lifetime;
			}
			set
			{
				if (_lifetime == value)
				{
					return;
				}
				_lifetime = value;
				PropertySet(this);
			}
		}

		public gameeventsRevealObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
