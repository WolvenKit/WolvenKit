using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContext : CVariable
	{
		private gamestateMachineStateSnapshotsContainer _snapshot;
		private gamestateMachineStateContextParameters _permanentParameters;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshotsContainer Snapshot
		{
			get
			{
				if (_snapshot == null)
				{
					_snapshot = (gamestateMachineStateSnapshotsContainer) CR2WTypeManager.Create("gamestateMachineStateSnapshotsContainer", "snapshot", cr2w, this);
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
		[RED("permanentParameters")] 
		public gamestateMachineStateContextParameters PermanentParameters
		{
			get
			{
				if (_permanentParameters == null)
				{
					_permanentParameters = (gamestateMachineStateContextParameters) CR2WTypeManager.Create("gamestateMachineStateContextParameters", "permanentParameters", cr2w, this);
				}
				return _permanentParameters;
			}
			set
			{
				if (_permanentParameters == value)
				{
					return;
				}
				_permanentParameters = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
