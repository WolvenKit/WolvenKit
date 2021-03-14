using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTabModsRequest : redEvent
	{
		private CBool _open;
		private CHandle<CyberwareDisplayWrapper> _wrapper;

		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get
			{
				if (_open == null)
				{
					_open = (CBool) CR2WTypeManager.Create("Bool", "open", cr2w, this);
				}
				return _open;
			}
			set
			{
				if (_open == value)
				{
					return;
				}
				_open = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wrapper")] 
		public CHandle<CyberwareDisplayWrapper> Wrapper
		{
			get
			{
				if (_wrapper == null)
				{
					_wrapper = (CHandle<CyberwareDisplayWrapper>) CR2WTypeManager.Create("handle:CyberwareDisplayWrapper", "wrapper", cr2w, this);
				}
				return _wrapper;
			}
			set
			{
				if (_wrapper == value)
				{
					return;
				}
				_wrapper = value;
				PropertySet(this);
			}
		}

		public CyberwareTabModsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
