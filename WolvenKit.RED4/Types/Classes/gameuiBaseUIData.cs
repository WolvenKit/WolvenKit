using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiBaseUIData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		public gameuiBaseUIData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
