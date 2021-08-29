using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisBluelineDescription : IScriptable
	{
		private CArray<CHandle<gameinteractionsvisBluelinePart>> _parts;
		private CEnum<ELogicOperator> _logicOperator;

		[Ordinal(0)] 
		[RED("parts")] 
		public CArray<CHandle<gameinteractionsvisBluelinePart>> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetProperty(ref _logicOperator);
			set => SetProperty(ref _logicOperator, value);
		}
	}
}
