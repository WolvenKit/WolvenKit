using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatDefeated : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CUInt32 _id;
		private CBool _detected;

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
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("detected")] 
		public CBool Detected
		{
			get
			{
				if (_detected == null)
				{
					_detected = (CBool) CR2WTypeManager.Create("Bool", "detected", cr2w, this);
				}
				return _detected;
			}
			set
			{
				if (_detected == value)
				{
					return;
				}
				_detected = value;
				PropertySet(this);
			}
		}

		public AIThreatDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
