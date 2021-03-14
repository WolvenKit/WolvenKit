using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateResponse : redEvent
	{
		private CBool _scanSuccessful;

		[Ordinal(0)] 
		[RED("scanSuccessful")] 
		public CBool ScanSuccessful
		{
			get
			{
				if (_scanSuccessful == null)
				{
					_scanSuccessful = (CBool) CR2WTypeManager.Create("Bool", "scanSuccessful", cr2w, this);
				}
				return _scanSuccessful;
			}
			set
			{
				if (_scanSuccessful == value)
				{
					return;
				}
				_scanSuccessful = value;
				PropertySet(this);
			}
		}

		public SecurityGateResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
