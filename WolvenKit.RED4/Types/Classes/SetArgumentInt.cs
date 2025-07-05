using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetArgumentInt : SetArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CInt32 CustomVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SetArgumentInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
