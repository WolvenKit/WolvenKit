using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		private inkImageWidgetReference _speedIndicator;
		private inkImageWidgetReference _mirroredSpeedIndicator;

		[Ordinal(1)] 
		[RED("speedIndicator")] 
		public inkImageWidgetReference SpeedIndicator
		{
			get => GetProperty(ref _speedIndicator);
			set => SetProperty(ref _speedIndicator, value);
		}

		[Ordinal(2)] 
		[RED("mirroredSpeedIndicator")] 
		public inkImageWidgetReference MirroredSpeedIndicator
		{
			get => GetProperty(ref _mirroredSpeedIndicator);
			set => SetProperty(ref _mirroredSpeedIndicator, value);
		}

		public SpeedIndicatorIconsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
