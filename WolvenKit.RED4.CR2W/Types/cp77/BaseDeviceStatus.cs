using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceStatus : ActionEnum
	{
		private CBool _isRestarting;

		[Ordinal(25)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get
			{
				if (_isRestarting == null)
				{
					_isRestarting = (CBool) CR2WTypeManager.Create("Bool", "isRestarting", cr2w, this);
				}
				return _isRestarting;
			}
			set
			{
				if (_isRestarting == value)
				{
					return;
				}
				_isRestarting = value;
				PropertySet(this);
			}
		}

		public BaseDeviceStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
