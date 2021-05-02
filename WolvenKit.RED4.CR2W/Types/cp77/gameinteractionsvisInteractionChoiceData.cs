using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionChoiceData : CVariable
	{
		private CName _inputAction;
		private CEnum<EInputKey> _rawInputKey;
		private CBool _isHoldAction;
		private CString _localizedName;
		private gameinteractionsChoiceTypeWrapper _type;
		private CArray<CVariant> _data;
		private gameinteractionsChoiceCaption _captionParts;

		[Ordinal(0)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get => GetProperty(ref _inputAction);
			set => SetProperty(ref _inputAction, value);
		}

		[Ordinal(1)] 
		[RED("rawInputKey")] 
		public CEnum<EInputKey> RawInputKey
		{
			get => GetProperty(ref _rawInputKey);
			set => SetProperty(ref _rawInputKey, value);
		}

		[Ordinal(2)] 
		[RED("isHoldAction")] 
		public CBool IsHoldAction
		{
			get => GetProperty(ref _isHoldAction);
			set => SetProperty(ref _isHoldAction, value);
		}

		[Ordinal(3)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(6)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetProperty(ref _captionParts);
			set => SetProperty(ref _captionParts, value);
		}

		public gameinteractionsvisInteractionChoiceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
