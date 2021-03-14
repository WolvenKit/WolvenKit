using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PendingSecuritySystemDisable : redEvent
	{
		private CBool _isPending;

		[Ordinal(0)] 
		[RED("isPending")] 
		public CBool IsPending
		{
			get
			{
				if (_isPending == null)
				{
					_isPending = (CBool) CR2WTypeManager.Create("Bool", "isPending", cr2w, this);
				}
				return _isPending;
			}
			set
			{
				if (_isPending == value)
				{
					return;
				}
				_isPending = value;
				PropertySet(this);
			}
		}

		public PendingSecuritySystemDisable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
