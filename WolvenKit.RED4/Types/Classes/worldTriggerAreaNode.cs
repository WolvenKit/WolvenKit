using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTriggerAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("notifiers")] 
		public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers
		{
			get => GetPropertyValue<CArray<CHandle<worldITriggerAreaNotifer>>>();
			set => SetPropertyValue<CArray<CHandle<worldITriggerAreaNotifer>>>(value);
		}

		public worldTriggerAreaNode()
		{
			Color = new CColor { Red = 255, Green = 160, Blue = 160, Alpha = 128 };
			Notifiers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
