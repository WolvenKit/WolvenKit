using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftStartDelayEvent : redEvent
	{
		private CInt32 _targetFloor;

		[Ordinal(0)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get
			{
				if (_targetFloor == null)
				{
					_targetFloor = (CInt32) CR2WTypeManager.Create("Int32", "targetFloor", cr2w, this);
				}
				return _targetFloor;
			}
			set
			{
				if (_targetFloor == value)
				{
					return;
				}
				_targetFloor = value;
				PropertySet(this);
			}
		}

		public LiftStartDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
