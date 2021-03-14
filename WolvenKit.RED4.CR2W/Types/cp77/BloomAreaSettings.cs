using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloomAreaSettings : IAreaSettings
	{
		private CFloat _luminanceThresholdMin;
		private CFloat _luminanceThresholdMax;
		private CFloat _sceneColorScale;
		private CFloat _bloomColorScale;
		private CUInt8 _numDownsamplePasses;
		private ShaftsAreaSettings _shaftsAreaSettings;

		[Ordinal(2)] 
		[RED("luminanceThresholdMin")] 
		public CFloat LuminanceThresholdMin
		{
			get
			{
				if (_luminanceThresholdMin == null)
				{
					_luminanceThresholdMin = (CFloat) CR2WTypeManager.Create("Float", "luminanceThresholdMin", cr2w, this);
				}
				return _luminanceThresholdMin;
			}
			set
			{
				if (_luminanceThresholdMin == value)
				{
					return;
				}
				_luminanceThresholdMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("luminanceThresholdMax")] 
		public CFloat LuminanceThresholdMax
		{
			get
			{
				if (_luminanceThresholdMax == null)
				{
					_luminanceThresholdMax = (CFloat) CR2WTypeManager.Create("Float", "luminanceThresholdMax", cr2w, this);
				}
				return _luminanceThresholdMax;
			}
			set
			{
				if (_luminanceThresholdMax == value)
				{
					return;
				}
				_luminanceThresholdMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sceneColorScale")] 
		public CFloat SceneColorScale
		{
			get
			{
				if (_sceneColorScale == null)
				{
					_sceneColorScale = (CFloat) CR2WTypeManager.Create("Float", "sceneColorScale", cr2w, this);
				}
				return _sceneColorScale;
			}
			set
			{
				if (_sceneColorScale == value)
				{
					return;
				}
				_sceneColorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public CFloat BloomColorScale
		{
			get
			{
				if (_bloomColorScale == null)
				{
					_bloomColorScale = (CFloat) CR2WTypeManager.Create("Float", "bloomColorScale", cr2w, this);
				}
				return _bloomColorScale;
			}
			set
			{
				if (_bloomColorScale == value)
				{
					return;
				}
				_bloomColorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numDownsamplePasses")] 
		public CUInt8 NumDownsamplePasses
		{
			get
			{
				if (_numDownsamplePasses == null)
				{
					_numDownsamplePasses = (CUInt8) CR2WTypeManager.Create("Uint8", "numDownsamplePasses", cr2w, this);
				}
				return _numDownsamplePasses;
			}
			set
			{
				if (_numDownsamplePasses == value)
				{
					return;
				}
				_numDownsamplePasses = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("shaftsAreaSettings")] 
		public ShaftsAreaSettings ShaftsAreaSettings
		{
			get
			{
				if (_shaftsAreaSettings == null)
				{
					_shaftsAreaSettings = (ShaftsAreaSettings) CR2WTypeManager.Create("ShaftsAreaSettings", "shaftsAreaSettings", cr2w, this);
				}
				return _shaftsAreaSettings;
			}
			set
			{
				if (_shaftsAreaSettings == value)
				{
					return;
				}
				_shaftsAreaSettings = value;
				PropertySet(this);
			}
		}

		public BloomAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
