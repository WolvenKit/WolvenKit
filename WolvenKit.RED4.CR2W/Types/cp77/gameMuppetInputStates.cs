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
			get
			{
				if (_replicationTime == null)
				{
					_replicationTime = (netTime) CR2WTypeManager.Create("netTime", "replicationTime", cr2w, this);
				}
				return _replicationTime;
			}
			set
			{
				if (_replicationTime == value)
				{
					return;
				}
				_replicationTime = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
