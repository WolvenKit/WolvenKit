using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAnimSetAnimNames : RedBaseClass
	{
		private CArray<CName> _animationNames;

		[Ordinal(0)] 
		[RED("animationNames")] 
		public CArray<CName> AnimationNames
		{
			get => GetProperty(ref _animationNames);
			set => SetProperty(ref _animationNames, value);
		}
	}
}
