using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FuseBoxControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("fuseBoxSkillChecks")] 
		public CHandle<EngineeringContainer> FuseBoxSkillChecks
		{
			get => GetPropertyValue<CHandle<EngineeringContainer>>();
			set => SetPropertyValue<CHandle<EngineeringContainer>>(value);
		}

		[Ordinal(109)] 
		[RED("isGenerator")] 
		public CBool IsGenerator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("isOverloaded")] 
		public CBool IsOverloaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FuseBoxControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
