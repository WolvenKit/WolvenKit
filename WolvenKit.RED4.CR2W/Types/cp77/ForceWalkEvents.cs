using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceWalkEvents : LocomotionGroundEvents
	{
		private CFloat _storedSpeedValue;

		[Ordinal(0)] 
		[RED("storedSpeedValue")] 
		public CFloat StoredSpeedValue
		{
			get
			{
				if (_storedSpeedValue == null)
				{
					_storedSpeedValue = (CFloat) CR2WTypeManager.Create("Float", "storedSpeedValue", cr2w, this);
				}
				return _storedSpeedValue;
			}
			set
			{
				if (_storedSpeedValue == value)
				{
					return;
				}
				_storedSpeedValue = value;
				PropertySet(this);
			}
		}

		public ForceWalkEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
