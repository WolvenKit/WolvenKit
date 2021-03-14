using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		private CBool _available;

		[Ordinal(0)] 
		[RED("available")] 
		public CBool Available
		{
			get
			{
				if (_available == null)
				{
					_available = (CBool) CR2WTypeManager.Create("Bool", "available", cr2w, this);
				}
				return _available;
			}
			set
			{
				if (_available == value)
				{
					return;
				}
				_available = value;
				PropertySet(this);
			}
		}

		public scnInterruptAvailability_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
