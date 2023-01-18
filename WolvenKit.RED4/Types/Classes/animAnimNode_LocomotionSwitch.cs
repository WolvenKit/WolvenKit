using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LocomotionSwitch : animAnimNode_Switch
	{
		[Ordinal(20)] 
		[RED("audioTagsPerInput")] 
		public CArray<CName> AudioTagsPerInput
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public animAnimNode_LocomotionSwitch()
		{
			AudioTagsPerInput = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
