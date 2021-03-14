using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealRequestEvent : redEvent
	{
		private CBool _shouldReveal;
		private entEntityID _requester;
		private CBool _oneFrame;

		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get
			{
				if (_shouldReveal == null)
				{
					_shouldReveal = (CBool) CR2WTypeManager.Create("Bool", "shouldReveal", cr2w, this);
				}
				return _shouldReveal;
			}
			set
			{
				if (_shouldReveal == value)
				{
					return;
				}
				_shouldReveal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (entEntityID) CR2WTypeManager.Create("entEntityID", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("oneFrame")] 
		public CBool OneFrame
		{
			get
			{
				if (_oneFrame == null)
				{
					_oneFrame = (CBool) CR2WTypeManager.Create("Bool", "oneFrame", cr2w, this);
				}
				return _oneFrame;
			}
			set
			{
				if (_oneFrame == value)
				{
					return;
				}
				_oneFrame = value;
				PropertySet(this);
			}
		}

		public RevealRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
