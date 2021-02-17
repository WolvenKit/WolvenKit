using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SNetworkLinkData : CVariable
	{
		[Ordinal(0)] [RED("beam")] public CHandle<gameFxInstance> Beam { get; set; }
		[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
		[Ordinal(2)] [RED("slaveID")] public entEntityID SlaveID { get; set; }
		[Ordinal(3)] [RED("masterID")] public entEntityID MasterID { get; set; }
		[Ordinal(4)] [RED("slavePos")] public Vector4 SlavePos { get; set; }
		[Ordinal(5)] [RED("masterPos")] public Vector4 MasterPos { get; set; }
		[Ordinal(6)] [RED("drawLink")] public CBool DrawLink { get; set; }
		[Ordinal(7)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(8)] [RED("isDynamic")] public CBool IsDynamic { get; set; }
		[Ordinal(9)] [RED("revealMaster")] public CBool RevealMaster { get; set; }
		[Ordinal(10)] [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(11)] [RED("permanent")] public CBool Permanent { get; set; }
		[Ordinal(12)] [RED("isPing")] public CBool IsPing { get; set; }
		[Ordinal(13)] [RED("isNetrunner")] public CBool IsNetrunner { get; set; }
		[Ordinal(14)] [RED("linkType")] public CEnum<ELinkType> LinkType { get; set; }
		[Ordinal(15)] [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(16)] [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(17)] [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(18)] [RED("weakLink")] public CBool WeakLink { get; set; }

		public SNetworkLinkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
