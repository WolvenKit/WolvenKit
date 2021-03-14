using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsApperanceMaterial : CVariable
	{
		private CName _apperanceName;
		private CName _materialFrom;
		private CName _material;

		[Ordinal(0)] 
		[RED("apperanceName")] 
		public CName ApperanceName
		{
			get
			{
				if (_apperanceName == null)
				{
					_apperanceName = (CName) CR2WTypeManager.Create("CName", "apperanceName", cr2w, this);
				}
				return _apperanceName;
			}
			set
			{
				if (_apperanceName == value)
				{
					return;
				}
				_apperanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("materialFrom")] 
		public CName MaterialFrom
		{
			get
			{
				if (_materialFrom == null)
				{
					_materialFrom = (CName) CR2WTypeManager.Create("CName", "materialFrom", cr2w, this);
				}
				return _materialFrom;
			}
			set
			{
				if (_materialFrom == value)
				{
					return;
				}
				_materialFrom = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("material")] 
		public CName Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CName) CR2WTypeManager.Create("CName", "material", cr2w, this);
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

		public physicsApperanceMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
