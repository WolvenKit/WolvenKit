using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LookAtApplyVehicleRestrictions : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("group")] 
		public CName Group
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("referenceBone")] 
		public animTransformIndex ReferenceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNode_LookAtApplyVehicleRestrictions()
		{
			Id = 4294967295;
			InputLink = new();
			ReferenceBone = new();
		}
	}
}
