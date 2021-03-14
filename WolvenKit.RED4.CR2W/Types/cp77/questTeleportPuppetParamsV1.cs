using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParamsV1 : questAICommandParams
	{
		private CHandle<questUniversalRef> _destinationRef;
		private Vector3 _destinationOffset;
		private CBool _doNavTest;
		private CBool _resetLookAt;
		private CBool _useFastTravelMechanism;
		private CBool _healAtTeleport;

		[Ordinal(0)] 
		[RED("destinationRef")] 
		public CHandle<questUniversalRef> DestinationRef
		{
			get
			{
				if (_destinationRef == null)
				{
					_destinationRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "destinationRef", cr2w, this);
				}
				return _destinationRef;
			}
			set
			{
				if (_destinationRef == value)
				{
					return;
				}
				_destinationRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get
			{
				if (_destinationOffset == null)
				{
					_destinationOffset = (Vector3) CR2WTypeManager.Create("Vector3", "destinationOffset", cr2w, this);
				}
				return _destinationOffset;
			}
			set
			{
				if (_destinationOffset == value)
				{
					return;
				}
				_destinationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CBool) CR2WTypeManager.Create("Bool", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("resetLookAt")] 
		public CBool ResetLookAt
		{
			get
			{
				if (_resetLookAt == null)
				{
					_resetLookAt = (CBool) CR2WTypeManager.Create("Bool", "resetLookAt", cr2w, this);
				}
				return _resetLookAt;
			}
			set
			{
				if (_resetLookAt == value)
				{
					return;
				}
				_resetLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useFastTravelMechanism")] 
		public CBool UseFastTravelMechanism
		{
			get
			{
				if (_useFastTravelMechanism == null)
				{
					_useFastTravelMechanism = (CBool) CR2WTypeManager.Create("Bool", "useFastTravelMechanism", cr2w, this);
				}
				return _useFastTravelMechanism;
			}
			set
			{
				if (_useFastTravelMechanism == value)
				{
					return;
				}
				_useFastTravelMechanism = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("healAtTeleport")] 
		public CBool HealAtTeleport
		{
			get
			{
				if (_healAtTeleport == null)
				{
					_healAtTeleport = (CBool) CR2WTypeManager.Create("Bool", "healAtTeleport", cr2w, this);
				}
				return _healAtTeleport;
			}
			set
			{
				if (_healAtTeleport == value)
				{
					return;
				}
				_healAtTeleport = value;
				PropertySet(this);
			}
		}

		public questTeleportPuppetParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
