using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionWidgetPackage : SWidgetPackage
	{
		private CHandle<gamedeviceAction> _action;
		private CBool _wasInitalized;
		private CArray<CHandle<gamedeviceAction>> _dependendActions;

		[Ordinal(17)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(18)] 
		[RED("wasInitalized")] 
		public CBool WasInitalized
		{
			get => GetProperty(ref _wasInitalized);
			set => SetProperty(ref _wasInitalized, value);
		}

		[Ordinal(19)] 
		[RED("dependendActions")] 
		public CArray<CHandle<gamedeviceAction>> DependendActions
		{
			get => GetProperty(ref _dependendActions);
			set => SetProperty(ref _dependendActions, value);
		}

		public SActionWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
