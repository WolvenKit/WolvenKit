using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerBool : inkSettingsSelectorController
	{
		private inkWidgetReference _onState;
		private inkWidgetReference _offState;
		private inkWidgetReference _onStateBody;
		private inkWidgetReference _offStateBody;

		[Ordinal(15)] 
		[RED("onState")] 
		public inkWidgetReference OnState
		{
			get => GetProperty(ref _onState);
			set => SetProperty(ref _onState, value);
		}

		[Ordinal(16)] 
		[RED("offState")] 
		public inkWidgetReference OffState
		{
			get => GetProperty(ref _offState);
			set => SetProperty(ref _offState, value);
		}

		[Ordinal(17)] 
		[RED("onStateBody")] 
		public inkWidgetReference OnStateBody
		{
			get => GetProperty(ref _onStateBody);
			set => SetProperty(ref _onStateBody, value);
		}

		[Ordinal(18)] 
		[RED("offStateBody")] 
		public inkWidgetReference OffStateBody
		{
			get => GetProperty(ref _offStateBody);
			set => SetProperty(ref _offStateBody, value);
		}

		public SettingsSelectorControllerBool(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
