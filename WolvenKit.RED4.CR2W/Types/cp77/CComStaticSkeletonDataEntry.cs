using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CComStaticSkeletonDataEntry : CVariable
	{
		private CInt32 _boneIndex;
		private CFloat _mass;
		private Vector4 _locationLS;

		[Ordinal(0)] 
		[RED("boneIndex")] 
		public CInt32 BoneIndex
		{
			get
			{
				if (_boneIndex == null)
				{
					_boneIndex = (CInt32) CR2WTypeManager.Create("Int32", "boneIndex", cr2w, this);
				}
				return _boneIndex;
			}
			set
			{
				if (_boneIndex == value)
				{
					return;
				}
				_boneIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("locationLS")] 
		public Vector4 LocationLS
		{
			get
			{
				if (_locationLS == null)
				{
					_locationLS = (Vector4) CR2WTypeManager.Create("Vector4", "locationLS", cr2w, this);
				}
				return _locationLS;
			}
			set
			{
				if (_locationLS == value)
				{
					return;
				}
				_locationLS = value;
				PropertySet(this);
			}
		}

		public CComStaticSkeletonDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
