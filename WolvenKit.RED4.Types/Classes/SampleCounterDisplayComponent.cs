using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleCounterDisplayComponent : gameScriptableComponent
	{
		private gamePersistentID _targetPersistentID;

		[Ordinal(5)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetProperty(ref _targetPersistentID);
			set => SetProperty(ref _targetPersistentID, value);
		}
	}
}
