using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveCooldownRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("cid")] 
		public CInt32 Cid
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RemoveCooldownRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
