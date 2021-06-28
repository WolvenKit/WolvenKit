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
			get => GetProperty(ref _magnitude);
			set => SetProperty(ref _magnitude, value);
		}

		public questVehicleCollision_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
