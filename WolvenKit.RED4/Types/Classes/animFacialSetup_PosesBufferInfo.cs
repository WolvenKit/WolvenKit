using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup_PosesBufferInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("face")] 
		public animFacialSetup_OneSermoPoseBufferInfo Face
		{
			get => GetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>(value);
		}

		[Ordinal(1)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoPoseBufferInfo Tongue
		{
			get => GetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>(value);
		}

		[Ordinal(2)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoPoseBufferInfo Eyes
		{
			get => GetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoPoseBufferInfo>(value);
		}

		public animFacialSetup_PosesBufferInfo()
		{
			Face = new animFacialSetup_OneSermoPoseBufferInfo();
			Tongue = new animFacialSetup_OneSermoPoseBufferInfo();
			Eyes = new animFacialSetup_OneSermoPoseBufferInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
