using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private ReflectorSFX _reflectorSFX;

		[Ordinal(108)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get
			{
				if (_reflectorSFX == null)
				{
					_reflectorSFX = (ReflectorSFX) CR2WTypeManager.Create("ReflectorSFX", "reflectorSFX", cr2w, this);
				}
				return _reflectorSFX;
			}
			set
			{
				if (_reflectorSFX == value)
				{
					return;
				}
				_reflectorSFX = value;
				PropertySet(this);
			}
		}

		public BlindingLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
