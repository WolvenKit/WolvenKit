using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackInstance : ModuleInstance
	{
		private CBool _open;
		private CBool _process;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("process")] 
		public CBool Process
		{
			get
			{
				if (_process == null)
				{
					_process = (CBool) CR2WTypeManager.Create("Bool", "process", cr2w, this);
				}
				return _process;
			}
			set
			{
				if (_process == value)
				{
					return;
				}
				_process = value;
				PropertySet(this);
			}
		}

		public QuickhackInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
