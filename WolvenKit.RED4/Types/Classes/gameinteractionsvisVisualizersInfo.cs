using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisVisualizersInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activeVisId")] 
		public CInt32 ActiveVisId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("visIds")] 
		public CArray<CInt32> VisIds
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public gameinteractionsvisVisualizersInfo()
		{
			ActiveVisId = -1;
			VisIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
