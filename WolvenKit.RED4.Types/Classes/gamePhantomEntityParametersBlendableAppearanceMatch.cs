using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhantomEntityParametersBlendableAppearanceMatch : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blendable")] 
		public CName Blendable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("notBlendable")] 
		public CName NotBlendable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
