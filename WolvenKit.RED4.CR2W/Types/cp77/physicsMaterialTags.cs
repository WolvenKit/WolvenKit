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
			get
			{
				if (_aiVisibility == null)
				{
					_aiVisibility = (CEnum<physicsMaterialTagAIVisibility>) CR2WTypeManager.Create("physicsMaterialTagAIVisibility", "aiVisibility", cr2w, this);
				}
				return _aiVisibility;
			}
			set
			{
				if (_aiVisibility == value)
				{
					return;
				}
				_aiVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("projectilePenetration")] 
		public CEnum<physicsMaterialTagProjectilePenetration> ProjectilePenetration
		{
			get
			{
				if (_projectilePenetration == null)
				{
					_projectilePenetration = (CEnum<physicsMaterialTagProjectilePenetration>) CR2WTypeManager.Create("physicsMaterialTagProjectilePenetration", "projectilePenetration", cr2w, this);
				}
				return _projectilePenetration;
			}
			set
			{
				if (_projectilePenetration == value)
				{
					return;
				}
				_projectilePenetration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicleTraction")] 
		public CEnum<physicsMaterialTagVehicleTraction> VehicleTraction
		{
			get
			{
				if (_vehicleTraction == null)
				{
					_vehicleTraction = (CEnum<physicsMaterialTagVehicleTraction>) CR2WTypeManager.Create("physicsMaterialTagVehicleTraction", "vehicleTraction", cr2w, this);
				}
				return _vehicleTraction;
			}
			set
			{
				if (_vehicleTraction == value)
				{
					return;
				}
				_vehicleTraction = value;
				PropertySet(this);
			}
		}

		public physicsMaterialTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
