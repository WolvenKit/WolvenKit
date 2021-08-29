using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBodyTypeAnimationDefinition : RedBaseClass
	{
		private CResourceAsyncReference<animRig> _rig;
		private CArray<CResourceAsyncReference<animAnimSet>> _animsets;
		private CArray<gameAnimationOverrideDefinition> _overrides;

		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("animsets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> Animsets
		{
			get => GetProperty(ref _animsets);
			set => SetProperty(ref _animsets, value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimationOverrideDefinition> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}
	}
}
