using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequestEvent : redEvent
	{
		private CHandle<OutlineRequest> _outlineRequest;
		private CBool _flag;

		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get
			{
				if (_outlineRequest == null)
				{
					_outlineRequest = (CHandle<OutlineRequest>) CR2WTypeManager.Create("handle:OutlineRequest", "outlineRequest", cr2w, this);
				}
				return _outlineRequest;
			}
			set
			{
				if (_outlineRequest == value)
				{
					return;
				}
				_outlineRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("flag")] 
		public CBool Flag
		{
			get
			{
				if (_flag == null)
				{
					_flag = (CBool) CR2WTypeManager.Create("Bool", "flag", cr2w, this);
				}
				return _flag;
			}
			set
			{
				if (_flag == value)
				{
					return;
				}
				_flag = value;
				PropertySet(this);
			}
		}

		public OutlineRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
