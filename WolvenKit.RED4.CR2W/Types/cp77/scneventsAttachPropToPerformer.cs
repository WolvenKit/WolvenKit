using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToPerformer : scnSceneEvent
	{
		private scnPropId _propId;
		private scnPerformerId _performerId;
		private CName _slot;
		private CEnum<scnOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slot")] 
		public CName Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (CName) CR2WTypeManager.Create("CName", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get
			{
				if (_offsetMode == null)
				{
					_offsetMode = (CEnum<scnOffsetMode>) CR2WTypeManager.Create("scnOffsetMode", "offsetMode", cr2w, this);
				}
				return _offsetMode;
			}
			set
			{
				if (_offsetMode == value)
				{
					return;
				}
				_offsetMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get
			{
				if (_customOffsetPos == null)
				{
					_customOffsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "customOffsetPos", cr2w, this);
				}
				return _customOffsetPos;
			}
			set
			{
				if (_customOffsetPos == value)
				{
					return;
				}
				_customOffsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get
			{
				if (_customOffsetRot == null)
				{
					_customOffsetRot = (Quaternion) CR2WTypeManager.Create("Quaternion", "customOffsetRot", cr2w, this);
				}
				return _customOffsetRot;
			}
			set
			{
				if (_customOffsetRot == value)
				{
					return;
				}
				_customOffsetRot = value;
				PropertySet(this);
			}
		}

		public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
