using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCookedPointOfInterestMappinData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameCookedPointOfInterestMappinData()
		{
			EntityID = new();
			Position = new();
		}
	}
}
