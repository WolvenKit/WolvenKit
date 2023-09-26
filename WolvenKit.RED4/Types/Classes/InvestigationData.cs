using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InvestigationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetPropertyValue<worldGlobalNodeRef>();
			set => SetPropertyValue<worldGlobalNodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public InvestigationData()
		{
			GlobalNodeRef = new worldGlobalNodeRef();
			InvestigationPositionsArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
