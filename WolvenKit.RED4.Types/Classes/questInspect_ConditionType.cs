using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInspect_ConditionType : questIObjectConditionType
	{
		private CString _objectID;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get => GetProperty(ref _objectID);
			set => SetProperty(ref _objectID, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
