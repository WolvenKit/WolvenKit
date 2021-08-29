using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimationOverrideDefinition : RedBaseClass
	{
		private CResourceAsyncReference<animAnimSet> _animset;
		private CArray<CName> _variables;

		[Ordinal(0)] 
		[RED("animset")] 
		public CResourceAsyncReference<animAnimSet> Animset
		{
			get => GetProperty(ref _animset);
			set => SetProperty(ref _animset, value);
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}
	}
}
