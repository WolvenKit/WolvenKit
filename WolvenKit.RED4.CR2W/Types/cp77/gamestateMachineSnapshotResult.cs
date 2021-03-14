using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineSnapshotResult : CVariable
	{
		private gamestateMachineStateSnapshot _snapshot;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshot Snapshot
		{
			get
			{
				if (_snapshot == null)
				{
					_snapshot = (gamestateMachineStateSnapshot) CR2WTypeManager.Create("gamestateMachineStateSnapshot", "snapshot", cr2w, this);
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

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get
			{
				if (_valid == null)
				{
					_valid = (CBool) CR2WTypeManager.Create("Bool", "valid", cr2w, this);
				}
				return _valid;
			}
			set
			{
				if (_valid == value)
				{
					return;
				}
				_valid = value;
				PropertySet(this);
			}
		}

		public gamestateMachineSnapshotResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
