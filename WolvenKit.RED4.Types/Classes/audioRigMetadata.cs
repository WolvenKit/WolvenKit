using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRigMetadata : audioAudioMetadata
	{
		private CArray<CName> _positionBones;
		private CName _defaultBone;

		[Ordinal(1)] 
		[RED("positionBones")] 
		public CArray<CName> PositionBones
		{
			get => GetProperty(ref _positionBones);
			set => SetProperty(ref _positionBones, value);
		}

		[Ordinal(2)] 
		[RED("defaultBone")] 
		public CName DefaultBone
		{
			get => GetProperty(ref _defaultBone);
			set => SetProperty(ref _defaultBone, value);
		}
	}
}
