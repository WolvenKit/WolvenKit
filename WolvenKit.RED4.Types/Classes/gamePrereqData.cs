using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePrereqData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bAndValues")] 
		public CBool BAndValues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("prereqList")] 
		public CArray<gamePrereqCheckData> PrereqList
		{
			get => GetPropertyValue<CArray<gamePrereqCheckData>>();
			set => SetPropertyValue<CArray<gamePrereqCheckData>>(value);
		}

		public gamePrereqData()
		{
			PrereqList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
