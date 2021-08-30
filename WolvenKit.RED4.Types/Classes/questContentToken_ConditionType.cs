using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questContentToken_ConditionType : questIContentConditionType
	{
		private CEnum<questQuestContentType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questQuestContentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questContentToken_ConditionType()
		{
			_type = new() { Value = Enums.questQuestContentType.MainQuest };
		}
	}
}
