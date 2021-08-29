using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsNotifyFootstepMaterialContextChanged : redEvent
	{
		private CName _footwareType;
		private CName _surfaceFlavourName;

		[Ordinal(0)] 
		[RED("footwareType")] 
		public CName FootwareType
		{
			get => GetProperty(ref _footwareType);
			set => SetProperty(ref _footwareType, value);
		}

		[Ordinal(1)] 
		[RED("surfaceFlavourName")] 
		public CName SurfaceFlavourName
		{
			get => GetProperty(ref _surfaceFlavourName);
			set => SetProperty(ref _surfaceFlavourName, value);
		}
	}
}
