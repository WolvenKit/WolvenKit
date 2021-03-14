using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedMultiMappinData : CVariable
	{
		private CUInt32 _journalPathHash;
		private CArray<Vector3> _positions;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get
			{
				if (_journalPathHash == null)
				{
					_journalPathHash = (CUInt32) CR2WTypeManager.Create("Uint32", "journalPathHash", cr2w, this);
				}
				return _journalPathHash;
			}
			set
			{
				if (_journalPathHash == value)
				{
					return;
				}
				_journalPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("positions")] 
		public CArray<Vector3> Positions
		{
			get
			{
				if (_positions == null)
				{
					_positions = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "positions", cr2w, this);
				}
				return _positions;
			}
			set
			{
				if (_positions == value)
				{
					return;
				}
				_positions = value;
				PropertySet(this);
			}
		}

		public gameCookedMultiMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
