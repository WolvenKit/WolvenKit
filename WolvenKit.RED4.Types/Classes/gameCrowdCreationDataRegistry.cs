using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCrowdCreationDataRegistry : ISerializable
	{
		private CArray<gameCrowdCreationData> _creationData;

		[Ordinal(0)] 
		[RED("creationData")] 
		public CArray<gameCrowdCreationData> CreationData
		{
			get => GetProperty(ref _creationData);
			set => SetProperty(ref _creationData, value);
		}
	}
}
