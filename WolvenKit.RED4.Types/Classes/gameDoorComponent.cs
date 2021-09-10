using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDoorComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("interactible")] 
		public CBool Interactible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("automatic")] 
		public CBool Automatic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("physical")] 
		public CBool Physical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("autoOpeningSpeed")] 
		public CFloat AutoOpeningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameDoorComponent()
		{
			Name = "Component";
			Interactible = true;
			AutoOpeningSpeed = 1.000000F;
		}
	}
}
