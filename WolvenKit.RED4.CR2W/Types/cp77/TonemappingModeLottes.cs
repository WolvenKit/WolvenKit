using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeLottes : ITonemappingMode
	{
		private CFloat _maxInput;
		private CFloat _contrast;
		private CFloat _midIn;
		private CFloat _midOut;
		private Vector3 _crosstalk;
		private Vector3 _crosstalkSaturation;

		[Ordinal(1)] 
		[RED("maxInput")] 
		public CFloat MaxInput
		{
			get
			{
				if (_maxInput == null)
				{
					_maxInput = (CFloat) CR2WTypeManager.Create("Float", "maxInput", cr2w, this);
				}
				return _maxInput;
			}
			set
			{
				if (_maxInput == value)
				{
					return;
				}
				_maxInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get
			{
				if (_contrast == null)
				{
					_contrast = (CFloat) CR2WTypeManager.Create("Float", "contrast", cr2w, this);
				}
				return _contrast;
			}
			set
			{
				if (_contrast == value)
				{
					return;
				}
				_contrast = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("midIn")] 
		public CFloat MidIn
		{
			get
			{
				if (_midIn == null)
				{
					_midIn = (CFloat) CR2WTypeManager.Create("Float", "midIn", cr2w, this);
				}
				return _midIn;
			}
			set
			{
				if (_midIn == value)
				{
					return;
				}
				_midIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("midOut")] 
		public CFloat MidOut
		{
			get
			{
				if (_midOut == null)
				{
					_midOut = (CFloat) CR2WTypeManager.Create("Float", "midOut", cr2w, this);
				}
				return _midOut;
			}
			set
			{
				if (_midOut == value)
				{
					return;
				}
				_midOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("crosstalk")] 
		public Vector3 Crosstalk
		{
			get
			{
				if (_crosstalk == null)
				{
					_crosstalk = (Vector3) CR2WTypeManager.Create("Vector3", "crosstalk", cr2w, this);
				}
				return _crosstalk;
			}
			set
			{
				if (_crosstalk == value)
				{
					return;
				}
				_crosstalk = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("crosstalkSaturation")] 
		public Vector3 CrosstalkSaturation
		{
			get
			{
				if (_crosstalkSaturation == null)
				{
					_crosstalkSaturation = (Vector3) CR2WTypeManager.Create("Vector3", "crosstalkSaturation", cr2w, this);
				}
				return _crosstalkSaturation;
			}
			set
			{
				if (_crosstalkSaturation == value)
				{
					return;
				}
				_crosstalkSaturation = value;
				PropertySet(this);
			}
		}

		public TonemappingModeLottes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
