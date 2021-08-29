using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMenuAccountLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _playerId;
		private inkTextWidgetReference _changeAccountLabelTextRef;
		private inkWidgetReference _inputDisplayControllerRef;
		private CBool _changeAccountEnabled;

		[Ordinal(1)] 
		[RED("playerId")] 
		public inkTextWidgetReference PlayerId
		{
			get => GetProperty(ref _playerId);
			set => SetProperty(ref _playerId, value);
		}

		[Ordinal(2)] 
		[RED("changeAccountLabelTextRef")] 
		public inkTextWidgetReference ChangeAccountLabelTextRef
		{
			get => GetProperty(ref _changeAccountLabelTextRef);
			set => SetProperty(ref _changeAccountLabelTextRef, value);
		}

		[Ordinal(3)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get => GetProperty(ref _inputDisplayControllerRef);
			set => SetProperty(ref _inputDisplayControllerRef, value);
		}

		[Ordinal(4)] 
		[RED("changeAccountEnabled")] 
		public CBool ChangeAccountEnabled
		{
			get => GetProperty(ref _changeAccountEnabled);
			set => SetProperty(ref _changeAccountEnabled, value);
		}
	}
}
