using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioLogicController : inkWidgetLogicController
	{
		private CBool _isSoundStopped;

		[Ordinal(1)] 
		[RED("isSoundStopped")] 
		public CBool IsSoundStopped
		{
			get
			{
				if (_isSoundStopped == null)
				{
					_isSoundStopped = (CBool) CR2WTypeManager.Create("Bool", "isSoundStopped", cr2w, this);
				}
				return _isSoundStopped;
			}
			set
			{
				if (_isSoundStopped == value)
				{
					return;
				}
				_isSoundStopped = value;
				PropertySet(this);
			}
		}

		public VehicleRadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
