using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetInvestigationPositionsArrayEvent : redEvent
	{
		private CArray<Vector4> _investigationPositionsArray;

		[Ordinal(0)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetProperty(ref _investigationPositionsArray);
			set => SetProperty(ref _investigationPositionsArray, value);
		}
	}
}
