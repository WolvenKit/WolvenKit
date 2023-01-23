using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup_BufferInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tracksMapping")] 
		public animFacialSetup_TracksMapping TracksMapping
		{
			get => GetPropertyValue<animFacialSetup_TracksMapping>();
			set => SetPropertyValue<animFacialSetup_TracksMapping>(value);
		}

		[Ordinal(1)] 
		[RED("numLipsyncOverridesIndexMapping")] 
		public CUInt16 NumLipsyncOverridesIndexMapping
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("numJointRegions")] 
		public CUInt16 NumJointRegions
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("face")] 
		public animFacialSetup_OneSermoBufferInfo Face
		{
			get => GetPropertyValue<animFacialSetup_OneSermoBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoBufferInfo>(value);
		}

		[Ordinal(4)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoBufferInfo Eyes
		{
			get => GetPropertyValue<animFacialSetup_OneSermoBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoBufferInfo>(value);
		}

		[Ordinal(5)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoBufferInfo Tongue
		{
			get => GetPropertyValue<animFacialSetup_OneSermoBufferInfo>();
			set => SetPropertyValue<animFacialSetup_OneSermoBufferInfo>(value);
		}

		public animFacialSetup_BufferInfo()
		{
			TracksMapping = new();
			Face = new();
			Eyes = new();
			Tongue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
