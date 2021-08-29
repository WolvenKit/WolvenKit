using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhantomEntityParametersBlendableAppearanceMatch : RedBaseClass
	{
		private CName _blendable;
		private CName _notBlendable;

		[Ordinal(0)] 
		[RED("blendable")] 
		public CName Blendable
		{
			get => GetProperty(ref _blendable);
			set => SetProperty(ref _blendable, value);
		}

		[Ordinal(1)] 
		[RED("notBlendable")] 
		public CName NotBlendable
		{
			get => GetProperty(ref _notBlendable);
			set => SetProperty(ref _notBlendable, value);
		}
	}
}
