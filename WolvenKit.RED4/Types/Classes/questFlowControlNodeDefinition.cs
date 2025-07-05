using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("opensAt")] 
		public CUInt16 OpensAt
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(4)] 
		[RED("closesAt")] 
		public CUInt16 ClosesAt
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public questFlowControlNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			IsOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
