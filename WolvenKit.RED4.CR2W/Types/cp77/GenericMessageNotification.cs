using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotification : gameuiWidgetGameController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _message;
		private inkWidgetReference _buttonConfirm;
		private inkWidgetReference _buttonCancel;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonYes;
		private inkWidgetReference _buttonNo;
		private inkWidgetReference _root;
		private inkWidgetReference _background;
		private inkWidgetReference _buttonHintsRoot;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<GenericMessageNotificationData> _data;
		private CBool _isNegativeHovered;
		private CBool _isPositiveHovered;
		private inkWidgetLibraryReference _libraryPath;
		private CHandle<GenericMessageNotificationCloseData> _closeData;

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("message")] 
		public inkTextWidgetReference Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(4)] 
		[RED("buttonConfirm")] 
		public inkWidgetReference ButtonConfirm
		{
			get => GetProperty(ref _buttonConfirm);
			set => SetProperty(ref _buttonConfirm, value);
		}

		[Ordinal(5)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetProperty(ref _buttonCancel);
			set => SetProperty(ref _buttonCancel, value);
		}

		[Ordinal(6)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get => GetProperty(ref _buttonOk);
			set => SetProperty(ref _buttonOk, value);
		}

		[Ordinal(7)] 
		[RED("buttonYes")] 
		public inkWidgetReference ButtonYes
		{
			get => GetProperty(ref _buttonYes);
			set => SetProperty(ref _buttonYes, value);
		}

		[Ordinal(8)] 
		[RED("buttonNo")] 
		public inkWidgetReference ButtonNo
		{
			get => GetProperty(ref _buttonNo);
			set => SetProperty(ref _buttonNo, value);
		}

		[Ordinal(9)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<GenericMessageNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(14)] 
		[RED("isNegativeHovered")] 
		public CBool IsNegativeHovered
		{
			get => GetProperty(ref _isNegativeHovered);
			set => SetProperty(ref _isNegativeHovered, value);
		}

		[Ordinal(15)] 
		[RED("isPositiveHovered")] 
		public CBool IsPositiveHovered
		{
			get => GetProperty(ref _isPositiveHovered);
			set => SetProperty(ref _isPositiveHovered, value);
		}

		[Ordinal(16)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(17)] 
		[RED("closeData")] 
		public CHandle<GenericMessageNotificationCloseData> CloseData
		{
			get => GetProperty(ref _closeData);
			set => SetProperty(ref _closeData, value);
		}

		public GenericMessageNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
