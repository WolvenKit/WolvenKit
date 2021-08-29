using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoice : RedBaseClass
	{
		private CString _caption;
		private gameinteractionsChoiceCaption _captionParts;
		private CArray<CVariant> _data;
		private gameinteractionsChoiceMetaData _choiceMetaData;
		private gameinteractionsChoiceLookAtDescriptor _lookAtDescriptor;

		[Ordinal(0)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetProperty(ref _caption);
			set => SetProperty(ref _caption, value);
		}

		[Ordinal(1)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetProperty(ref _captionParts);
			set => SetProperty(ref _captionParts, value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(3)] 
		[RED("choiceMetaData")] 
		public gameinteractionsChoiceMetaData ChoiceMetaData
		{
			get => GetProperty(ref _choiceMetaData);
			set => SetProperty(ref _choiceMetaData, value);
		}

		[Ordinal(4)] 
		[RED("lookAtDescriptor")] 
		public gameinteractionsChoiceLookAtDescriptor LookAtDescriptor
		{
			get => GetProperty(ref _lookAtDescriptor);
			set => SetProperty(ref _lookAtDescriptor, value);
		}
	}
}
