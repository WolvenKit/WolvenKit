using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivateDevice : ActionBool
	{
		[Ordinal(38)] 
		[RED("tweakDBChoiceName")] 
		public CString TweakDBChoiceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ActivateDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
