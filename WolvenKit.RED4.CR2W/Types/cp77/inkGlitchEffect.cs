using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGlitchEffect : inkIEffect
	{
		private CFloat _intensity;
		private CFloat _offsetX;
		private CFloat _offsetY;
		private CFloat _sizeX;
		private CFloat _sizeY;

		[Ordinal(2)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get
			{
				if (_offsetX == null)
				{
					_offsetX = (CFloat) CR2WTypeManager.Create("Float", "offsetX", cr2w, this);
				}
				return _offsetX;
			}
			set
			{
				if (_offsetX == value)
				{
					return;
				}
				_offsetX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get
			{
				if (_offsetY == null)
				{
					_offsetY = (CFloat) CR2WTypeManager.Create("Float", "offsetY", cr2w, this);
				}
				return _offsetY;
			}
			set
			{
				if (_offsetY == value)
				{
					return;
				}
				_offsetY = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sizeX")] 
		public CFloat SizeX
		{
			get
			{
				if (_sizeX == null)
				{
					_sizeX = (CFloat) CR2WTypeManager.Create("Float", "sizeX", cr2w, this);
				}
				return _sizeX;
			}
			set
			{
				if (_sizeX == value)
				{
					return;
				}
				_sizeX = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sizeY")] 
		public CFloat SizeY
		{
			get
			{
				if (_sizeY == null)
				{
					_sizeY = (CFloat) CR2WTypeManager.Create("Float", "sizeY", cr2w, this);
				}
				return _sizeY;
			}
			set
			{
				if (_sizeY == value)
				{
					return;
				}
				_sizeY = value;
				PropertySet(this);
			}
		}

		public inkGlitchEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
