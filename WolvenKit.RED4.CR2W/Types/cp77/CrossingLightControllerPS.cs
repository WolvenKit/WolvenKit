using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightControllerPS : TrafficLightControllerPS
	{
		private CrossingLightSetup _crossingLightSFXSetup;

		[Ordinal(103)] 
		[RED("crossingLightSFXSetup")] 
		public CrossingLightSetup CrossingLightSFXSetup
		{
			get
			{
				if (_crossingLightSFXSetup == null)
				{
					_crossingLightSFXSetup = (CrossingLightSetup) CR2WTypeManager.Create("CrossingLightSetup", "crossingLightSFXSetup", cr2w, this);
				}
				return _crossingLightSFXSetup;
			}
			set
			{
				if (_crossingLightSFXSetup == value)
				{
					return;
				}
				_crossingLightSFXSetup = value;
				PropertySet(this);
			}
		}

		public CrossingLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
