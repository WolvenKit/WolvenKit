using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatExpectationInvalid : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CUInt32 _threatId;

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get
			{
				if (_threat == null)
				{
					_threat = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "threat", cr2w, this);
				}
				return _threat;
			}
			set
			{
				if (_threat == value)
				{
					return;
				}
				_threat = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("threatId")] 
		public CUInt32 ThreatId
		{
			get
			{
				if (_threatId == null)
				{
					_threatId = (CUInt32) CR2WTypeManager.Create("Uint32", "threatId", cr2w, this);
				}
				return _threatId;
			}
			set
			{
				if (_threatId == value)
				{
					return;
				}
				_threatId = value;
				PropertySet(this);
			}
		}

		public AIThreatExpectationInvalid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
