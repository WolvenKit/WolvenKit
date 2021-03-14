using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarData : CVariable
	{
		private CString _header;
		private CBool _active;
		private CFloat _progress;

		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get
			{
				if (_header == null)
				{
					_header = (CString) CR2WTypeManager.Create("String", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (CFloat) CR2WTypeManager.Create("Float", "progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		public HUDProgressBarData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
