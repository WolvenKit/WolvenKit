using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entHardTransformBinding : entITransformBinding
	{
		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entHardTransformBinding()
		{
			Enabled = true;
			EnableMask = new() { HardTags = new() { Tags = new() }, SoftTags = new() { Tags = new() }, ExcludedTags = new() { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
