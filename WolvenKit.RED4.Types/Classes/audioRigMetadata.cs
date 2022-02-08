using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRigMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("positionBones")] 
		public CArray<CName> PositionBones
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("defaultBone")] 
		public CName DefaultBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioRigMetadata()
		{
			PositionBones = new();
		}
	}
}
