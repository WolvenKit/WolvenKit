using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animBoneCorrection : RedBaseClass
	{
		private CName _boneName;
		private Quaternion _additiveCorrection;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("additiveCorrection")] 
		public Quaternion AdditiveCorrection
		{
			get => GetProperty(ref _additiveCorrection);
			set => SetProperty(ref _additiveCorrection, value);
		}
	}
}
