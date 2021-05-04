using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionsInputView : inkWidgetLogicController
	{
		private inkWidgetReference _topArrowRef;
		private inkWidgetReference _botArrowRef;
		private inkImageWidgetReference _inputImage;
		private CBool _showArrows;
		private CBool _hasAbove;
		private CBool _hasBelow;
		private CInt32 _currentNum;
		private CInt32 _allItemsNum;
		private CName _defaultInputPartName;

		[Ordinal(1)] 
		[RED("TopArrowRef")] 
		public inkWidgetReference TopArrowRef
		{
			get => GetProperty(ref _topArrowRef);
			set => SetProperty(ref _topArrowRef, value);
		}

		[Ordinal(2)] 
		[RED("BotArrowRef")] 
		public inkWidgetReference BotArrowRef
		{
			get => GetProperty(ref _botArrowRef);
			set => SetProperty(ref _botArrowRef, value);
		}

		[Ordinal(3)] 
		[RED("InputImage")] 
		public inkImageWidgetReference InputImage
		{
			get => GetProperty(ref _inputImage);
			set => SetProperty(ref _inputImage, value);
		}

		[Ordinal(4)] 
		[RED("ShowArrows")] 
		public CBool ShowArrows
		{
			get => GetProperty(ref _showArrows);
			set => SetProperty(ref _showArrows, value);
		}

		[Ordinal(5)] 
		[RED("HasAbove")] 
		public CBool HasAbove
		{
			get => GetProperty(ref _hasAbove);
			set => SetProperty(ref _hasAbove, value);
		}

		[Ordinal(6)] 
		[RED("HasBelow")] 
		public CBool HasBelow
		{
			get => GetProperty(ref _hasBelow);
			set => SetProperty(ref _hasBelow, value);
		}

		[Ordinal(7)] 
		[RED("CurrentNum")] 
		public CInt32 CurrentNum
		{
			get => GetProperty(ref _currentNum);
			set => SetProperty(ref _currentNum, value);
		}

		[Ordinal(8)] 
		[RED("AllItemsNum")] 
		public CInt32 AllItemsNum
		{
			get => GetProperty(ref _allItemsNum);
			set => SetProperty(ref _allItemsNum, value);
		}

		[Ordinal(9)] 
		[RED("DefaultInputPartName")] 
		public CName DefaultInputPartName
		{
			get => GetProperty(ref _defaultInputPartName);
			set => SetProperty(ref _defaultInputPartName, value);
		}

		public InteractionsInputView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
