using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealQuestTargetEvent : redEvent
	{
		private CName _sourceName;
		private CEnum<ERevealDurationType> _durationType;
		private CBool _reveal;
		private CFloat _timeout;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("durationType")] 
		public CEnum<ERevealDurationType> DurationType
		{
			get
			{
				if (_durationType == null)
				{
					_durationType = (CEnum<ERevealDurationType>) CR2WTypeManager.Create("ERevealDurationType", "durationType", cr2w, this);
				}
				return _durationType;
			}
			set
			{
				if (_durationType == value)
				{
					return;
				}
				_durationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get
			{
				if (_timeout == null)
				{
					_timeout = (CFloat) CR2WTypeManager.Create("Float", "timeout", cr2w, this);
				}
				return _timeout;
			}
			set
			{
				if (_timeout == value)
				{
					return;
				}
				_timeout = value;
				PropertySet(this);
			}
		}

		public RevealQuestTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
