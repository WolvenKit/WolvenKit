using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardSerializableID : RedBaseClass
	{
		private CName _blackboardName;
		private CName _fieldName;

		[Ordinal(0)] 
		[RED("blackboardName")] 
		public CName BlackboardName
		{
			get => GetProperty(ref _blackboardName);
			set => SetProperty(ref _blackboardName, value);
		}

		[Ordinal(1)] 
		[RED("fieldName")] 
		public CName FieldName
		{
			get => GetProperty(ref _fieldName);
			set => SetProperty(ref _fieldName, value);
		}
	}
}
