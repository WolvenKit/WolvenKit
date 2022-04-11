using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetInvestigationPositionsArrayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public SetInvestigationPositionsArrayEvent()
		{
			InvestigationPositionsArray = new();
		}
	}
}
