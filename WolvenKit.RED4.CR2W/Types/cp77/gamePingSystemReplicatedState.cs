using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<gamePingEntry> _replicatedPingEntries;

		[Ordinal(0)] 
		[RED("replicatedPingEntries")] 
		public CArray<gamePingEntry> ReplicatedPingEntries
		{
			get
			{
				if (_replicatedPingEntries == null)
				{
					_replicatedPingEntries = (CArray<gamePingEntry>) CR2WTypeManager.Create("array:gamePingEntry", "replicatedPingEntries", cr2w, this);
				}
				return _replicatedPingEntries;
			}
			set
			{
				if (_replicatedPingEntries == value)
				{
					return;
				}
				_replicatedPingEntries = value;
				PropertySet(this);
			}
		}

		public gamePingSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
