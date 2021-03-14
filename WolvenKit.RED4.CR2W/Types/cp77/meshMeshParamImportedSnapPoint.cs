using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamImportedSnapPoint : meshMeshParameter
	{
		private CArray<CHandle<meshMeshImportedSnapPoint>> _snapFeatureData;

		[Ordinal(0)] 
		[RED("snapFeatureData")] 
		public CArray<CHandle<meshMeshImportedSnapPoint>> SnapFeatureData
		{
			get
			{
				if (_snapFeatureData == null)
				{
					_snapFeatureData = (CArray<CHandle<meshMeshImportedSnapPoint>>) CR2WTypeManager.Create("array:handle:meshMeshImportedSnapPoint", "snapFeatureData", cr2w, this);
				}
				return _snapFeatureData;
			}
			set
			{
				if (_snapFeatureData == value)
				{
					return;
				}
				_snapFeatureData = value;
				PropertySet(this);
			}
		}

		public meshMeshParamImportedSnapPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
