using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedMappinData : CVariable
	{
		private CUInt32 _journalPathHash;
		private Vector3 _position;
		private CHandle<gamemappinsIMappinVolume> _volume;

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
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get
			{
				if (_volume == null)
				{
					_volume = (CHandle<gamemappinsIMappinVolume>) CR2WTypeManager.Create("handle:gamemappinsIMappinVolume", "volume", cr2w, this);
				}
				return _volume;
			}
			set
			{
				if (_volume == value)
				{
					return;
				}
				_volume = value;
				PropertySet(this);
			}
		}

		public gameCookedMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
