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
			EnableMask = new entTagMask { HardTags = new redTagList { Tags = new() }, SoftTags = new redTagList { Tags = new() }, ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
