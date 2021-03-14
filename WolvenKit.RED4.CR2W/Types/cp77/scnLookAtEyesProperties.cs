using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEyesProperties : CVariable
	{
		private CFloat _enableFactor;
		private CFloat _override;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("enableFactor")] 
		public CFloat EnableFactor
		{
			get
			{
				if (_enableFactor == null)
				{
					_enableFactor = (CFloat) CR2WTypeManager.Create("Float", "enableFactor", cr2w, this);
				}
				return _enableFactor;
			}
			set
			{
				if (_enableFactor == value)
				{
					return;
				}
				_enableFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CFloat Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CFloat) CR2WTypeManager.Create("Float", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CInt32) CR2WTypeManager.Create("Int32", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public scnLookAtEyesProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
