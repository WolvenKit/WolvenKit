using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		private CFloat _windDir;
		private CFloat _windSpeed;
		private CFloat _windScale;
		private CFloat _amplitude;
		private CFloat _lambda;

		[Ordinal(0)] 
		[RED("windDir")] 
		public CFloat WindDir
		{
			get
			{
				if (_windDir == null)
				{
					_windDir = (CFloat) CR2WTypeManager.Create("Float", "windDir", cr2w, this);
				}
				return _windDir;
			}
			set
			{
				if (_windDir == value)
				{
					return;
				}
				_windDir = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("windSpeed")] 
		public CFloat WindSpeed
		{
			get
			{
				if (_windSpeed == null)
				{
					_windSpeed = (CFloat) CR2WTypeManager.Create("Float", "windSpeed", cr2w, this);
				}
				return _windSpeed;
			}
			set
			{
				if (_windSpeed == value)
				{
					return;
				}
				_windSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("windScale")] 
		public CFloat WindScale
		{
			get
			{
				if (_windScale == null)
				{
					_windScale = (CFloat) CR2WTypeManager.Create("Float", "windScale", cr2w, this);
				}
				return _windScale;
			}
			set
			{
				if (_windScale == value)
				{
					return;
				}
				_windScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("amplitude")] 
		public CFloat Amplitude
		{
			get
			{
				if (_amplitude == null)
				{
					_amplitude = (CFloat) CR2WTypeManager.Create("Float", "amplitude", cr2w, this);
				}
				return _amplitude;
			}
			set
			{
				if (_amplitude == value)
				{
					return;
				}
				_amplitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lambda")] 
		public CFloat Lambda
		{
			get
			{
				if (_lambda == null)
				{
					_lambda = (CFloat) CR2WTypeManager.Create("Float", "lambda", cr2w, this);
				}
				return _lambda;
			}
			set
			{
				if (_lambda == value)
				{
					return;
				}
				_lambda = value;
				PropertySet(this);
			}
		}

		public CRenderSimWaterFFT(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
