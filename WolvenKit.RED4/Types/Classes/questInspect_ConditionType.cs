using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInspect_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questInspect_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
