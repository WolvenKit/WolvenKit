using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleStartDynamicMovementEvent : redEvent
	{
		private Vector3 _targetPosition;

		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector3) CR2WTypeManager.Create("Vector3", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		public vehicleStartDynamicMovementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
