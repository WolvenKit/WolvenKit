using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCollision_ConditionType : questIVehicleConditionType
	{
		private CEnum<questImpulseMagnitude> _magnitude;

		[Ordinal(0)] 
		[RED("magnitude")] 
		public CEnum<questImpulseMagnitude> Magnitude
		{
			get
			{
				if (_magnitude == null)
				{
					_magnitude = (CEnum<questImpulseMagnitude>) CR2WTypeManager.Create("questImpulseMagnitude", "magnitude", cr2w, this);
				}
				return _magnitude;
			}
			set
			{
				if (_magnitude == value)
				{
					return;
				}
				_magnitude = value;
				PropertySet(this);
			}
		}

		public questVehicleCollision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
