using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMinimize_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("minimize")] 
		public CBool Minimize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMinimize_NodeType()
		{
			Minimize = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
