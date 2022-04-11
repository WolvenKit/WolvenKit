using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTriggerAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("notifiers")] 
		public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers
		{
			get => GetPropertyValue<CArray<CHandle<worldITriggerAreaNotifer>>>();
			set => SetPropertyValue<CArray<CHandle<worldITriggerAreaNotifer>>>(value);
		}

		public worldTriggerAreaNode()
		{
			Notifiers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
