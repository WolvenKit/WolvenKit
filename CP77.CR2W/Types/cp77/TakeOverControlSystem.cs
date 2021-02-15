using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TakeOverControlSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("controlledObject")] public wCHandle<gameObject> ControlledObject { get; set; }
		[Ordinal(1)] [RED("isInputRegistered")] public CBool IsInputRegistered { get; set; }
		[Ordinal(2)] [RED("isInputLockedFromQuest")] public CBool IsInputLockedFromQuest { get; set; }
		[Ordinal(3)] [RED("isChainForcedFromQuest")] public CBool IsChainForcedFromQuest { get; set; }
		[Ordinal(4)] [RED("isActionButtonLocked")] public CBool IsActionButtonLocked { get; set; }
		[Ordinal(5)] [RED("isDeviceChainCreationLocked")] public CBool IsDeviceChainCreationLocked { get; set; }
		[Ordinal(6)] [RED("chainLockSources")] public CArray<CName> ChainLockSources { get; set; }
		[Ordinal(7)] [RED("TCDUpdateDelayID")] public gameDelayID TCDUpdateDelayID { get; set; }
		[Ordinal(8)] [RED("TCSupdateRate")] public CFloat TCSupdateRate { get; set; }
		[Ordinal(9)] [RED("lastInputSimTime")] public CFloat LastInputSimTime { get; set; }

		public TakeOverControlSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
