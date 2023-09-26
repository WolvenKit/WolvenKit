using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		[Ordinal(36)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(37)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public SampleInteractiveEntityThatBumpsTheCounter()
		{
			TargetPersistentID = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
