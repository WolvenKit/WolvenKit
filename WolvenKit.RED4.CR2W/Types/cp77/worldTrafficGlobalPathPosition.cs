using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficGlobalPathPosition : ISerializable
	{
		private Vector3 _worldPosition;
		private CUInt32 _pathIdx;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector3) CR2WTypeManager.Create("Vector3", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pathIdx")] 
		public CUInt32 PathIdx
		{
			get
			{
				if (_pathIdx == null)
				{
					_pathIdx = (CUInt32) CR2WTypeManager.Create("Uint32", "pathIdx", cr2w, this);
				}
				return _pathIdx;
			}
			set
			{
				if (_pathIdx == value)
				{
					return;
				}
				_pathIdx = value;
				PropertySet(this);
			}
		}

		public worldTrafficGlobalPathPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
