using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceData : CVariable
	{
		private CString _localizedName;
		private gameinteractionsChoiceTypeWrapper _type;
		private CName _inputActionName;
		private gameinteractionsChoiceCaption _captionParts;
		private wCHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

		[Ordinal(0)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetProperty(ref _inputActionName);
			set => SetProperty(ref _inputActionName, value);
		}

		[Ordinal(3)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetProperty(ref _captionParts);
			set => SetProperty(ref _captionParts, value);
		}

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetProperty(ref _timeProvider);
			set => SetProperty(ref _timeProvider, value);
		}

		public gameinteractionsvisListChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
