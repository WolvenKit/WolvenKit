using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFuncCallEntry : ISerializable
	{
		private EngineTime _callTime;
		private CUInt32 _callId;

		[Ordinal(0)] 
		[RED("callTime")] 
		public EngineTime CallTime
		{
			get
			{
				if (_callTime == null)
				{
					_callTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "callTime", cr2w, this);
				}
				return _callTime;
			}
			set
			{
				if (_callTime == value)
				{
					return;
				}
				_callTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("callId")] 
		public CUInt32 CallId
		{
			get
			{
				if (_callId == null)
				{
					_callId = (CUInt32) CR2WTypeManager.Create("Uint32", "callId", cr2w, this);
				}
				return _callId;
			}
			set
			{
				if (_callId == value)
				{
					return;
				}
				_callId = value;
				PropertySet(this);
			}
		}

		public gameFuncCallEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
