using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectEventInfo : CVariable
	{
		private CRUID _eventRUID;
		private CUInt64 _placementIndexMask;
		private CUInt64 _componentIndexMask;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("eventRUID")] 
		public CRUID EventRUID
		{
			get
			{
				if (_eventRUID == null)
				{
					_eventRUID = (CRUID) CR2WTypeManager.Create("CRUID", "eventRUID", cr2w, this);
				}
				return _eventRUID;
			}
			set
			{
				if (_eventRUID == value)
				{
					return;
				}
				_eventRUID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("placementIndexMask")] 
		public CUInt64 PlacementIndexMask
		{
			get
			{
				if (_placementIndexMask == null)
				{
					_placementIndexMask = (CUInt64) CR2WTypeManager.Create("Uint64", "placementIndexMask", cr2w, this);
				}
				return _placementIndexMask;
			}
			set
			{
				if (_placementIndexMask == value)
				{
					return;
				}
				_placementIndexMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("componentIndexMask")] 
		public CUInt64 ComponentIndexMask
		{
			get
			{
				if (_componentIndexMask == null)
				{
					_componentIndexMask = (CUInt64) CR2WTypeManager.Create("Uint64", "componentIndexMask", cr2w, this);
				}
				return _componentIndexMask;
			}
			set
			{
				if (_componentIndexMask == value)
				{
					return;
				}
				_componentIndexMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt8) CR2WTypeManager.Create("Uint8", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public worldCompiledEffectEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
