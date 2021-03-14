using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStreamingTestCheckpoint_NodeType : questIWorldDataManagerNodeType
	{
		private CEnum<worldStreamingTestCheckpointType> _checkpointType;

		[Ordinal(0)] 
		[RED("checkpointType")] 
		public CEnum<worldStreamingTestCheckpointType> CheckpointType
		{
			get
			{
				if (_checkpointType == null)
				{
					_checkpointType = (CEnum<worldStreamingTestCheckpointType>) CR2WTypeManager.Create("worldStreamingTestCheckpointType", "checkpointType", cr2w, this);
				}
				return _checkpointType;
			}
			set
			{
				if (_checkpointType == value)
				{
					return;
				}
				_checkpointType = value;
				PropertySet(this);
			}
		}

		public questStreamingTestCheckpoint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
