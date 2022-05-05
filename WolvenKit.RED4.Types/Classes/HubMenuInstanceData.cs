using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HubMenuInstanceData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public HubMenuInstanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
