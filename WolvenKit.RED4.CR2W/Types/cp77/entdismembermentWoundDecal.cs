using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundDecal : CVariable
	{
		private Vector3 _offsetA;
		private Vector3 _offsetB;
		private CFloat _scale;
		private CFloat _fadeOrigin;
		private CFloat _fadePower;
		private CEnum<entdismembermentResourceSetMask> _resourceSets;
		private raRef<IMaterial> _material;

		[Ordinal(0)] 
		[RED("OffsetA")] 
		public Vector3 OffsetA
		{
			get
			{
				if (_offsetA == null)
				{
					_offsetA = (Vector3) CR2WTypeManager.Create("Vector3", "OffsetA", cr2w, this);
				}
				return _offsetA;
			}
			set
			{
				if (_offsetA == value)
				{
					return;
				}
				_offsetA = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("OffsetB")] 
		public Vector3 OffsetB
		{
			get
			{
				if (_offsetB == null)
				{
					_offsetB = (Vector3) CR2WTypeManager.Create("Vector3", "OffsetB", cr2w, this);
				}
				return _offsetB;
			}
			set
			{
				if (_offsetB == value)
				{
					return;
				}
				_offsetB = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "Scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("FadeOrigin")] 
		public CFloat FadeOrigin
		{
			get
			{
				if (_fadeOrigin == null)
				{
					_fadeOrigin = (CFloat) CR2WTypeManager.Create("Float", "FadeOrigin", cr2w, this);
				}
				return _fadeOrigin;
			}
			set
			{
				if (_fadeOrigin == value)
				{
					return;
				}
				_fadeOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("FadePower")] 
		public CFloat FadePower
		{
			get
			{
				if (_fadePower == null)
				{
					_fadePower = (CFloat) CR2WTypeManager.Create("Float", "FadePower", cr2w, this);
				}
				return _fadePower;
			}
			set
			{
				if (_fadePower == value)
				{
					return;
				}
				_fadePower = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CEnum<entdismembermentResourceSetMask> ResourceSets
		{
			get
			{
				if (_resourceSets == null)
				{
					_resourceSets = (CEnum<entdismembermentResourceSetMask>) CR2WTypeManager.Create("entdismembermentResourceSetMask", "ResourceSets", cr2w, this);
				}
				return _resourceSets;
			}
			set
			{
				if (_resourceSets == value)
				{
					return;
				}
				_resourceSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Material")] 
		public raRef<IMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (raRef<IMaterial>) CR2WTypeManager.Create("raRef:IMaterial", "Material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		public entdismembermentWoundDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
