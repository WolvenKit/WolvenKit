using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshotsContainer : CVariable
	{
		private CArray<gamestateMachineStateSnapshot> _snapshot;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public CArray<gamestateMachineStateSnapshot> Snapshot
		{
			get
			{
				if (_snapshot == null)
				{
					_snapshot = (CArray<gamestateMachineStateSnapshot>) CR2WTypeManager.Create("array:gamestateMachineStateSnapshot", "snapshot", cr2w, this);
				}
				return _snapshot;
			}
			set
			{
				if (_snapshot == value)
				{
					return;
				}
				_snapshot = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateSnapshotsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
