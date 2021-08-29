using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		private NodeRef _targetEntityWithCounter;
		private gamePersistentID _targetPersistentID;

		[Ordinal(40)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get => GetProperty(ref _targetEntityWithCounter);
			set => SetProperty(ref _targetEntityWithCounter, value);
		}

		[Ordinal(41)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetProperty(ref _targetPersistentID);
			set => SetProperty(ref _targetPersistentID, value);
		}
	}
}
