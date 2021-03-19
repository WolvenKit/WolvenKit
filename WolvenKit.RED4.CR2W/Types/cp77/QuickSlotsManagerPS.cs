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
			get => GetProperty(ref _activeVehicleType);
			set => SetProperty(ref _activeVehicleType, value);
		}

		public QuickSlotsManagerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
