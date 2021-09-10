using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		[Ordinal(40)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(41)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public SampleInteractiveEntityThatBumpsTheCounter()
		{
			TargetPersistentID = new();
		}
	}
}
