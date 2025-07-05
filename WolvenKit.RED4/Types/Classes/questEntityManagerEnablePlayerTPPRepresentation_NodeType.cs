using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerEnablePlayerTPPRepresentation_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEntityManagerEnablePlayerTPPRepresentation_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
