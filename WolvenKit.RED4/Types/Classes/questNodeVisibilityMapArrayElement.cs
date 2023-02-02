using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questNodeVisibilityMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetPropertyValue<worldGlobalNodeRef>();
			set => SetPropertyValue<worldGlobalNodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questNodeVisibilityMapArrayElement()
		{
			GlobalNodeRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
