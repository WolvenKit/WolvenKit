using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehEntityPlayerStateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entID")] 
		public entEntityID EntID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VehEntityPlayerStateData()
		{
			EntID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
