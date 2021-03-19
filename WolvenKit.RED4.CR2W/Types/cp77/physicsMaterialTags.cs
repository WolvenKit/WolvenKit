using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialTags : CVariable
	{
		private CEnum<physicsMaterialTagAIVisibility> _aiVisibility;
		private CEnum<physicsMaterialTagProjectilePenetration> _projectilePenetration;
		private CEnum<physicsMaterialTagVehicleTraction> _vehicleTraction;

		[Ordinal(0)] 
		[RED("aiVisibility")] 
		public CEnum<physicsMaterialTagAIVisibility> AiVisibility
		{
			get => GetProperty(ref _aiVisibility);
			set => SetProperty(ref _aiVisibility, value);
		}

		[Ordinal(1)] 
		[RED("projectilePenetration")] 
		public CEnum<physicsMaterialTagProjectilePenetration> ProjectilePenetration
		{
			get => GetProperty(ref _projectilePenetration);
			set => SetProperty(ref _projectilePenetration, value);
		}

		[Ordinal(2)] 
		[RED("vehicleTraction")] 
		public CEnum<physicsMaterialTagVehicleTraction> VehicleTraction
		{
			get => GetProperty(ref _vehicleTraction);
			set => SetProperty(ref _vehicleTraction, value);
		}

		public physicsMaterialTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
