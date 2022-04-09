using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisBluelineDescription : IScriptable
	{
		[Ordinal(0)] 
		[RED("parts")] 
		public CArray<CHandle<gameinteractionsvisBluelinePart>> Parts
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsvisBluelinePart>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsvisBluelinePart>>>(value);
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetPropertyValue<CEnum<ELogicOperator>>();
			set => SetPropertyValue<CEnum<ELogicOperator>>(value);
		}

		public gameinteractionsvisBluelineDescription()
		{
			Parts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
