using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemSupport : redEvent
	{
		private CBool _supportGranted;

		[Ordinal(0)] 
		[RED("supportGranted")] 
		public CBool SupportGranted
		{
			get
			{
				if (_supportGranted == null)
				{
					_supportGranted = (CBool) CR2WTypeManager.Create("Bool", "supportGranted", cr2w, this);
				}
				return _supportGranted;
			}
			set
			{
				if (_supportGranted == value)
				{
					return;
				}
				_supportGranted = value;
				PropertySet(this);
			}
		}

		public SecuritySystemSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
