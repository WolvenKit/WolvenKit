using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInnerGlowEffect : inkIEffect
	{
		private CFloat _colorR;
		private CFloat _colorG;
		private CFloat _colorB;
		private CFloat _colorA;
		private CFloat _offsetX;
		private CFloat _offsetY;

		[Ordinal(2)] 
		[RED("colorR")] 
		public CFloat ColorR
		{
			get
			{
				if (_colorR == null)
				{
					_colorR = (CFloat) CR2WTypeManager.Create("Float", "colorR", cr2w, this);
				}
				return _colorR;
			}
			set
			{
				if (_colorR == value)
				{
					return;
				}
				_colorR = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("colorG")] 
		public CFloat ColorG
		{
			get
			{
				if (_colorG == null)
				{
					_colorG = (CFloat) CR2WTypeManager.Create("Float", "colorG", cr2w, this);
				}
				return _colorG;
			}
			set
			{
				if (_colorG == value)
				{
					return;
				}
				_colorG = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("colorB")] 
		public CFloat ColorB
		{
			get
			{
				if (_colorB == null)
				{
					_colorB = (CFloat) CR2WTypeManager.Create("Float", "colorB", cr2w, this);
				}
				return _colorB;
			}
			set
			{
				if (_colorB == value)
				{
					return;
				}
				_colorB = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("colorA")] 
		public CFloat ColorA
		{
			get
			{
				if (_colorA == null)
				{
					_colorA = (CFloat) CR2WTypeManager.Create("Float", "colorA", cr2w, this);
				}
				return _colorA;
			}
			set
			{
				if (_colorA == value)
				{
					return;
				}
				_colorA = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		public inkInnerGlowEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
