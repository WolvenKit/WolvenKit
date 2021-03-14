using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInfoEvent : redEvent
	{
		private CString _tag;
		private CUInt32 _entitiesGathered;
		private CUInt32 _entitiesFiltered;
		private CUInt32 _entitiesProcessed;

		[Ordinal(0)] 
		[RED("tag")] 
		public CString Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CString) CR2WTypeManager.Create("String", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entitiesGathered")] 
		public CUInt32 EntitiesGathered
		{
			get
			{
				if (_entitiesGathered == null)
				{
					_entitiesGathered = (CUInt32) CR2WTypeManager.Create("Uint32", "entitiesGathered", cr2w, this);
				}
				return _entitiesGathered;
			}
			set
			{
				if (_entitiesGathered == value)
				{
					return;
				}
				_entitiesGathered = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entitiesFiltered")] 
		public CUInt32 EntitiesFiltered
		{
			get
			{
				if (_entitiesFiltered == null)
				{
					_entitiesFiltered = (CUInt32) CR2WTypeManager.Create("Uint32", "entitiesFiltered", cr2w, this);
				}
				return _entitiesFiltered;
			}
			set
			{
				if (_entitiesFiltered == value)
				{
					return;
				}
				_entitiesFiltered = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entitiesProcessed")] 
		public CUInt32 EntitiesProcessed
		{
			get
			{
				if (_entitiesProcessed == null)
				{
					_entitiesProcessed = (CUInt32) CR2WTypeManager.Create("Uint32", "entitiesProcessed", cr2w, this);
				}
				return _entitiesProcessed;
			}
			set
			{
				if (_entitiesProcessed == value)
				{
					return;
				}
				_entitiesProcessed = value;
				PropertySet(this);
			}
		}

		public gameEffectInfoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
