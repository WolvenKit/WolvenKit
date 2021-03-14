using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDeformableShapesData : meshMeshParameter
	{
		private CArray<CUInt8> _ownerIndex;
		private CArray<Transform> _startingPose;
		private CArray<Transform> _finalPose;

		[Ordinal(0)] 
		[RED("ownerIndex")] 
		public CArray<CUInt8> OwnerIndex
		{
			get
			{
				if (_ownerIndex == null)
				{
					_ownerIndex = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "ownerIndex", cr2w, this);
				}
				return _ownerIndex;
			}
			set
			{
				if (_ownerIndex == value)
				{
					return;
				}
				_ownerIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startingPose")] 
		public CArray<Transform> StartingPose
		{
			get
			{
				if (_startingPose == null)
				{
					_startingPose = (CArray<Transform>) CR2WTypeManager.Create("array:Transform", "startingPose", cr2w, this);
				}
				return _startingPose;
			}
			set
			{
				if (_startingPose == value)
				{
					return;
				}
				_startingPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("finalPose")] 
		public CArray<Transform> FinalPose
		{
			get
			{
				if (_finalPose == null)
				{
					_finalPose = (CArray<Transform>) CR2WTypeManager.Create("array:Transform", "finalPose", cr2w, this);
				}
				return _finalPose;
			}
			set
			{
				if (_finalPose == value)
				{
					return;
				}
				_finalPose = value;
				PropertySet(this);
			}
		}

		public meshMeshParamDeformableShapesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
