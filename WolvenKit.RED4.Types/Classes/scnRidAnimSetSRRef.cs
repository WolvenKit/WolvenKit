using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidAnimSetSRRef : RedBaseClass
	{
		private CArray<scnSRRefId> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnSRRefId> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}
	}
}
