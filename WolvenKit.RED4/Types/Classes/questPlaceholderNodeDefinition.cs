using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlaceholderNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("replacedNodeClassName")] 
		public CName ReplacedNodeClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("copiedSockets")] 
		public CArray<questPlaceholderNodeSocketInfo> CopiedSockets
		{
			get => GetPropertyValue<CArray<questPlaceholderNodeSocketInfo>>();
			set => SetPropertyValue<CArray<questPlaceholderNodeSocketInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("clipboardHolder")] 
		public CHandle<ISerializable> ClipboardHolder
		{
			get => GetPropertyValue<CHandle<ISerializable>>();
			set => SetPropertyValue<CHandle<ISerializable>>(value);
		}

		public questPlaceholderNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			CopiedSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
