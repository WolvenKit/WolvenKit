using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeLottesACES : ITonemappingMode
	{
		private CFloat _maxInput;
		private CFloat _contrast;
		private CFloat _midIn;
		private CFloat _midOut;

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

		public TonemappingModeLottesACES(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
