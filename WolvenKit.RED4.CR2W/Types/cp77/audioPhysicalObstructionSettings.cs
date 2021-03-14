using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		private CFloat _initialAbsorbtion;
		private CFloat _absorptionPerMeter;

		[Ordinal(1)] 
		[RED("initialAbsorbtion")] 
		public CFloat InitialAbsorbtion
		{
			get
			{
				if (_initialAbsorbtion == null)
				{
					_initialAbsorbtion = (CFloat) CR2WTypeManager.Create("Float", "initialAbsorbtion", cr2w, this);
				}
				return _initialAbsorbtion;
			}
			set
			{
				if (_initialAbsorbtion == value)
				{
					return;
				}
				_initialAbsorbtion = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("absorptionPerMeter")] 
		public CFloat AbsorptionPerMeter
		{
			get
			{
				if (_absorptionPerMeter == null)
				{
					_absorptionPerMeter = (CFloat) CR2WTypeManager.Create("Float", "absorptionPerMeter", cr2w, this);
				}
				return _absorptionPerMeter;
			}
			set
			{
				if (_absorptionPerMeter == value)
				{
					return;
				}
				_absorptionPerMeter = value;
				PropertySet(this);
			}
		}

		public audioPhysicalObstructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
