using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnprvSpawnDespawnItem : RedBaseClass
	{
		private TweakDBID _recordID;
		private Transform _finalTransform;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("finalTransform")] 
		public Transform FinalTransform
		{
			get => GetProperty(ref _finalTransform);
			set => SetProperty(ref _finalTransform, value);
		}
	}
}
