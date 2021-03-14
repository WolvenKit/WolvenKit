using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkGridOnPulse : redEvent
	{
		private CFloat _duration;
		private CBool _revealSlave;
		private CBool _revealMaster;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get
			{
				if (_revealSlave == null)
				{
					_revealSlave = (CBool) CR2WTypeManager.Create("Bool", "revealSlave", cr2w, this);
				}
				return _revealSlave;
			}
			set
			{
				if (_revealSlave == value)
				{
					return;
				}
				_revealSlave = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get
			{
				if (_revealMaster == null)
				{
					_revealMaster = (CBool) CR2WTypeManager.Create("Bool", "revealMaster", cr2w, this);
				}
				return _revealMaster;
			}
			set
			{
				if (_revealMaster == value)
				{
					return;
				}
				_revealMaster = value;
				PropertySet(this);
			}
		}

		public RevealNetworkGridOnPulse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
