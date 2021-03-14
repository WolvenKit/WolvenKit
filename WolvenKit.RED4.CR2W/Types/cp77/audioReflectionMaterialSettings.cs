using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReflectionMaterialSettings : audioAudioMetadata
	{
		private CFloat _lowPass;
		private CFloat _highPass;
		private CFloat _gain;

		[Ordinal(1)] 
		[RED("lowPass")] 
		public CFloat LowPass
		{
			get
			{
				if (_lowPass == null)
				{
					_lowPass = (CFloat) CR2WTypeManager.Create("Float", "lowPass", cr2w, this);
				}
				return _lowPass;
			}
			set
			{
				if (_lowPass == value)
				{
					return;
				}
				_lowPass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("highPass")] 
		public CFloat HighPass
		{
			get
			{
				if (_highPass == null)
				{
					_highPass = (CFloat) CR2WTypeManager.Create("Float", "highPass", cr2w, this);
				}
				return _highPass;
			}
			set
			{
				if (_highPass == value)
				{
					return;
				}
				_highPass = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gain")] 
		public CFloat Gain
		{
			get
			{
				if (_gain == null)
				{
					_gain = (CFloat) CR2WTypeManager.Create("Float", "gain", cr2w, this);
				}
				return _gain;
			}
			set
			{
				if (_gain == value)
				{
					return;
				}
				_gain = value;
				PropertySet(this);
			}
		}

		public audioReflectionMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
