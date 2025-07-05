using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdCreationDataRegistry : ISerializable
	{
		[Ordinal(0)] 
		[RED("creationData")] 
		public CArray<gameCrowdCreationData> CreationData
		{
			get => GetPropertyValue<CArray<gameCrowdCreationData>>();
			set => SetPropertyValue<CArray<gameCrowdCreationData>>(value);
		}

		public gameCrowdCreationDataRegistry()
		{
			CreationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
