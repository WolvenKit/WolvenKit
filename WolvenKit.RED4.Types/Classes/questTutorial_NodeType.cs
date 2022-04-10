using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTutorial_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questITutorial_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questITutorial_NodeSubType>>();
			set => SetPropertyValue<CHandle<questITutorial_NodeSubType>>(value);
		}

		public questTutorial_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
