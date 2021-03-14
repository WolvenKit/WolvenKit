using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSector : CResource
	{
		private CArray<rRef<CResource>> _localInplaceResource;
		private raRef<worldStreamingSectorInplaceContent> _externInplaceResource;
		private CUInt8 _level;
		private CInt8 _category;

		[Ordinal(1)] 
		[RED("localInplaceResource")] 
		public CArray<rRef<CResource>> LocalInplaceResource
		{
			get
			{
				if (_localInplaceResource == null)
				{
					_localInplaceResource = (CArray<rRef<CResource>>) CR2WTypeManager.Create("array:rRef:CResource", "localInplaceResource", cr2w, this);
				}
				return _localInplaceResource;
			}
			set
			{
				if (_localInplaceResource == value)
				{
					return;
				}
				_localInplaceResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("externInplaceResource")] 
		public raRef<worldStreamingSectorInplaceContent> ExternInplaceResource
		{
			get
			{
				if (_externInplaceResource == null)
				{
					_externInplaceResource = (raRef<worldStreamingSectorInplaceContent>) CR2WTypeManager.Create("raRef:worldStreamingSectorInplaceContent", "externInplaceResource", cr2w, this);
				}
				return _externInplaceResource;
			}
			set
			{
				if (_externInplaceResource == value)
				{
					return;
				}
				_externInplaceResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("level")] 
		public CUInt8 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CUInt8) CR2WTypeManager.Create("Uint8", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("category")] 
		public CInt8 Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CInt8) CR2WTypeManager.Create("Int8", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		public worldStreamingSector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
