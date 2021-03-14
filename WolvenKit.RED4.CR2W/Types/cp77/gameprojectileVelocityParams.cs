using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileVelocityParams : CVariable
	{
		private CFloat _xFactor;
		private CFloat _yFactor;
		private CFloat _zFactor;

		[Ordinal(0)] 
		[RED("xFactor")] 
		public CFloat XFactor
		{
			get
			{
				if (_xFactor == null)
				{
					_xFactor = (CFloat) CR2WTypeManager.Create("Float", "xFactor", cr2w, this);
				}
				return _xFactor;
			}
			set
			{
				if (_xFactor == value)
				{
					return;
				}
				_xFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("yFactor")] 
		public CFloat YFactor
		{
			get
			{
				if (_yFactor == null)
				{
					_yFactor = (CFloat) CR2WTypeManager.Create("Float", "yFactor", cr2w, this);
				}
				return _yFactor;
			}
			set
			{
				if (_yFactor == value)
				{
					return;
				}
				_yFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("zFactor")] 
		public CFloat ZFactor
		{
			get
			{
				if (_zFactor == null)
				{
					_zFactor = (CFloat) CR2WTypeManager.Create("Float", "zFactor", cr2w, this);
				}
				return _zFactor;
			}
			set
			{
				if (_zFactor == value)
				{
					return;
				}
				_zFactor = value;
				PropertySet(this);
			}
		}

		public gameprojectileVelocityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
