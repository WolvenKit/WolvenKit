using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealRequestsStorage : IScriptable
	{
		[Ordinal(0)] 
		[RED("currentRequestersAmount")] 
		public CInt32 CurrentRequestersAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("requestersList")] 
		public CArray<entEntityID> RequestersList
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public RevealRequestsStorage()
		{
			RequestersList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
