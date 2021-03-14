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
			get
			{
				if (_speedIndicator == null)
				{
					_speedIndicator = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "speedIndicator", cr2w, this);
				}
				return _speedIndicator;
			}
			set
			{
				if (_speedIndicator == value)
				{
					return;
				}
				_speedIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mirroredSpeedIndicator")] 
		public inkImageWidgetReference MirroredSpeedIndicator
		{
			get
			{
				if (_mirroredSpeedIndicator == null)
				{
					_mirroredSpeedIndicator = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "mirroredSpeedIndicator", cr2w, this);
				}
				return _mirroredSpeedIndicator;
			}
			set
			{
				if (_mirroredSpeedIndicator == value)
				{
					return;
				}
				_mirroredSpeedIndicator = value;
				PropertySet(this);
			}
		}

		public SpeedIndicatorIconsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
