using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationPersistantElements : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("headerHolder")] 
		public inkCompoundWidgetReference HeaderHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("LBBtn")] 
		public inkWidgetReference LBBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("RBBtn")] 
		public inkWidgetReference RBBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("fluffHolderRight")] 
		public inkCompoundWidgetReference FluffHolderRight
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("fluffHolderDown")] 
		public inkCompoundWidgetReference FluffHolderDown
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("fluffHolderLeft")] 
		public inkCompoundWidgetReference FluffHolderLeft
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("fluffTextRight")] 
		public inkTextWidgetReference FluffTextRight
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("fluffTextDown")] 
		public inkTextWidgetReference FluffTextDown
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("fluffTextLeft")] 
		public inkTextWidgetReference FluffTextLeft
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("headers")] 
		public CArray<CWeakHandle<CharacterCreationTopBarHeader>> Headers
		{
			get => GetPropertyValue<CArray<CWeakHandle<CharacterCreationTopBarHeader>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CharacterCreationTopBarHeader>>>(value);
		}

		[Ordinal(12)] 
		[RED("selectedHeader")] 
		public CWeakHandle<CharacterCreationTopBarHeader> SelectedHeader
		{
			get => GetPropertyValue<CWeakHandle<CharacterCreationTopBarHeader>>();
			set => SetPropertyValue<CWeakHandle<CharacterCreationTopBarHeader>>(value);
		}

		[Ordinal(13)] 
		[RED("c_fluffMaxX")] 
		public CFloat C_fluffMaxX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("c_fluffMinY")] 
		public CFloat C_fluffMinY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("c_fluffMaxY")] 
		public CFloat C_fluffMaxY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CharacterCreationPersistantElements()
		{
			HeaderHolder = new inkCompoundWidgetReference();
			LBBtn = new inkWidgetReference();
			RBBtn = new inkWidgetReference();
			FluffHolderRight = new inkCompoundWidgetReference();
			FluffHolderDown = new inkCompoundWidgetReference();
			FluffHolderLeft = new inkCompoundWidgetReference();
			FluffText1 = new inkTextWidgetReference();
			FluffTextRight = new inkTextWidgetReference();
			FluffTextDown = new inkTextWidgetReference();
			FluffTextLeft = new inkTextWidgetReference();
			Headers = new();
			C_fluffMaxX = 1800.000000F;
			C_fluffMinY = 300.000000F;
			C_fluffMaxY = 2000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
