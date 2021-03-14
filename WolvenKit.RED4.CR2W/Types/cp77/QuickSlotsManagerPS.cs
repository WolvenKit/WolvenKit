using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsManagerPS : gameComponentPS
	{
		private CEnum<gamedataVehicleType> _activeVehicleType;

		[Ordinal(0)] 
		[RED("activeVehicleType")] 
		public CEnum<gamedataVehicleType> ActiveVehicleType
		{
			get
			{
				if (_activeVehicleType == null)
				{
					_activeVehicleType = (CEnum<gamedataVehicleType>) CR2WTypeManager.Create("gamedataVehicleType", "activeVehicleType", cr2w, this);
				}
				return _activeVehicleType;
			}
			set
			{
				if (_activeVehicleType == value)
				{
					return;
				}
				_activeVehicleType = value;
				PropertySet(this);
			}
		}

		public QuickSlotsManagerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
