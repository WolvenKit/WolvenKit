using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeAllocationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("pointsContainer")] 
		public inkCompoundWidgetReference PointsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("attributeName")] 
		public inkTextWidgetReference AttributeName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("attributePoints")] 
		public inkTextWidgetReference AttributePoints
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("attributeIcon")] 
		public inkImageWidgetReference AttributeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<AttributeAllocationData> Data
		{
			get => GetPropertyValue<CHandle<AttributeAllocationData>>();
			set => SetPropertyValue<CHandle<AttributeAllocationData>>(value);
		}

		public AttributeAllocationController()
		{
			PointsContainer = new();
			AttributeName = new();
			AttributePoints = new();
			AttributeIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
