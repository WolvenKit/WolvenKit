using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDocumentWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] 
		[RED("owner")] 
		public CString Owner
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(18)] 
		[RED("date")] 
		public CString Date
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(20)] 
		[RED("content")] 
		public CString Content
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(21)] 
		[RED("image")] 
		public TweakDBID Image
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(22)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(23)] 
		[RED("isEncrypted")] 
		public CBool IsEncrypted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetPropertyValue<gamedeviceQuestInfo>();
			set => SetPropertyValue<gamedeviceQuestInfo>(value);
		}

		[Ordinal(25)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		public SDocumentWidgetPackage()
		{
			VideoPath = new();
			QuestInfo = new();
		}
	}
}
