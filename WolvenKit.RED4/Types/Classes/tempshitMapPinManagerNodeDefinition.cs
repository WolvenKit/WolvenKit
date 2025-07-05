using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class tempshitMapPinManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("mapPinName")] 
		public CName MapPinName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<tempshitMapPinOperation> Operation
		{
			get => GetPropertyValue<CEnum<tempshitMapPinOperation>>();
			set => SetPropertyValue<CEnum<tempshitMapPinOperation>>(value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public gameEntityReference NodeRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(5)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("forceCaption")] 
		public LocalizationString ForceCaption
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public tempshitMapPinManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			NodeRef = new gameEntityReference { Names = new() };
			Position = new Vector3();
			ForceCaption = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
