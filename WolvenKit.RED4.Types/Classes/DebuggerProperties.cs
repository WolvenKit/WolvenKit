using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebuggerProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("exclusiveMode")] 
		public CBool ExclusiveMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("factActivated")] 
		public CName FactActivated
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public DebuggerProperties()
		{
			LayerIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
