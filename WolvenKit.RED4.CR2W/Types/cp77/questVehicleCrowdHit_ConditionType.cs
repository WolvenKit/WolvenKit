using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCrowdHit_ConditionType : questIVehicleConditionType
	{
		private CBool _lethal;

		[Ordinal(0)] 
		[RED("lethal")] 
		public CBool Lethal
		{
			get => GetProperty(ref _lethal);
			set => SetProperty(ref _lethal, value);
		}

		public questVehicleCrowdHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
