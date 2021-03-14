using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDroneLocomotionWrapperEvent : redEvent
	{
		private CName _movementType;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CName) CR2WTypeManager.Create("CName", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		public ApplyDroneLocomotionWrapperEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
