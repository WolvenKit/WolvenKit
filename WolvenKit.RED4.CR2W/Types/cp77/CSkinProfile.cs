using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CSkinProfile : CResource
	{
		private CFloat _blurSize;
		private CColor _diffuse;
		private CColor _falloff;
		private CFloat _roughness0;
		private CFloat _roughness1;
		private CFloat _lobeMix;

		[Ordinal(1)] 
		[RED("blurSize")] 
		public CFloat BlurSize
		{
			get
			{
				if (_blurSize == null)
				{
					_blurSize = (CFloat) CR2WTypeManager.Create("Float", "blurSize", cr2w, this);
				}
				return _blurSize;
			}
			set
			{
				if (_blurSize == value)
				{
					return;
				}
				_blurSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("diffuse")] 
		public CColor Diffuse
		{
			get
			{
				if (_diffuse == null)
				{
					_diffuse = (CColor) CR2WTypeManager.Create("Color", "diffuse", cr2w, this);
				}
				return _diffuse;
			}
			set
			{
				if (_diffuse == value)
				{
					return;
				}
				_diffuse = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("falloff")] 
		public CColor Falloff
		{
			get
			{
				if (_falloff == null)
				{
					_falloff = (CColor) CR2WTypeManager.Create("Color", "falloff", cr2w, this);
				}
				return _falloff;
			}
			set
			{
				if (_falloff == value)
				{
					return;
				}
				_falloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("roughness0")] 
		public CFloat Roughness0
		{
			get
			{
				if (_roughness0 == null)
				{
					_roughness0 = (CFloat) CR2WTypeManager.Create("Float", "roughness0", cr2w, this);
				}
				return _roughness0;
			}
			set
			{
				if (_roughness0 == value)
				{
					return;
				}
				_roughness0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("roughness1")] 
		public CFloat Roughness1
		{
			get
			{
				if (_roughness1 == null)
				{
					_roughness1 = (CFloat) CR2WTypeManager.Create("Float", "roughness1", cr2w, this);
				}
				return _roughness1;
			}
			set
			{
				if (_roughness1 == value)
				{
					return;
				}
				_roughness1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lobeMix")] 
		public CFloat LobeMix
		{
			get
			{
				if (_lobeMix == null)
				{
					_lobeMix = (CFloat) CR2WTypeManager.Create("Float", "lobeMix", cr2w, this);
				}
				return _lobeMix;
			}
			set
			{
				if (_lobeMix == value)
				{
					return;
				}
				_lobeMix = value;
				PropertySet(this);
			}
		}

		public CSkinProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
