using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleTakeOverControl : ActionBool
	{
		private CBool _isRequestedFormOtherDevice;

		[Ordinal(25)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get
			{
				if (_isRequestedFormOtherDevice == null)
				{
					_isRequestedFormOtherDevice = (CBool) CR2WTypeManager.Create("Bool", "isRequestedFormOtherDevice", cr2w, this);
				}
				return _isRequestedFormOtherDevice;
			}
			set
			{
				if (_isRequestedFormOtherDevice == value)
				{
					return;
				}
				_isRequestedFormOtherDevice = value;
				PropertySet(this);
			}
		}

		public ToggleTakeOverControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
