using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		[Ordinal(35)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(36)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public SampleInteractiveEntityThatBumpsTheCounter()
		{
			TargetPersistentID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
