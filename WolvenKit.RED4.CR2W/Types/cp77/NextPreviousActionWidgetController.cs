using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkWidgetReference _defaultContainer;
		private inkWidgetReference _declineContainer;
		private CName _moneyStatusAnimName;
		private CBool _isProcessing;

		[Ordinal(28)] 
		[RED("defaultContainer")] 
		public inkWidgetReference DefaultContainer
		{
			get => GetProperty(ref _defaultContainer);
			set => SetProperty(ref _defaultContainer, value);
		}

		[Ordinal(29)] 
		[RED("declineContainer")] 
		public inkWidgetReference DeclineContainer
		{
			get => GetProperty(ref _declineContainer);
			set => SetProperty(ref _declineContainer, value);
		}

		[Ordinal(30)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get => GetProperty(ref _moneyStatusAnimName);
			set => SetProperty(ref _moneyStatusAnimName, value);
		}

		[Ordinal(31)] 
		[RED("isProcessing")] 
		public CBool IsProcessing
		{
			get => GetProperty(ref _isProcessing);
			set => SetProperty(ref _isProcessing, value);
		}

		public NextPreviousActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
