using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAppearanceToPlayerMetadata : CVariable
	{
		private CArray<CName> _appearances;
		private CName _foleyPlayerMetadata;
		private CEnum<audioFoleyItemPriority> _priority;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("foleyPlayerMetadata")] 
		public CName FoleyPlayerMetadata
		{
			get
			{
				if (_foleyPlayerMetadata == null)
				{
					_foleyPlayerMetadata = (CName) CR2WTypeManager.Create("CName", "foleyPlayerMetadata", cr2w, this);
				}
				return _foleyPlayerMetadata;
			}
			set
			{
				if (_foleyPlayerMetadata == value)
				{
					return;
				}
				_foleyPlayerMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<audioFoleyItemPriority> Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CEnum<audioFoleyItemPriority>) CR2WTypeManager.Create("audioFoleyItemPriority", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public audioAppearanceToPlayerMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
