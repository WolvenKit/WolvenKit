using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputStates : CVariable
	{
		private netTime _replicationTime;

		[Ordinal(0)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetProperty(ref _replicationTime);
			set => SetProperty(ref _replicationTime, value);
		}

		public gameMuppetInputStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
