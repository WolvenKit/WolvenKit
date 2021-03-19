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
			get => GetProperty(ref _boneIndex);
			set => SetProperty(ref _boneIndex, value);
		}

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(2)] 
		[RED("locationLS")] 
		public Vector4 LocationLS
		{
			get => GetProperty(ref _locationLS);
			set => SetProperty(ref _locationLS, value);
		}

		public CComStaticSkeletonDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
