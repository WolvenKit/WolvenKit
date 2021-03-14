using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegion : ISerializable
	{
		private CName _name;
		private CBool _isStretch;
		private CArray<rendTextureRegionPart> _regionParts;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isStretch")] 
		public CBool IsStretch
		{
			get
			{
				if (_isStretch == null)
				{
					_isStretch = (CBool) CR2WTypeManager.Create("Bool", "isStretch", cr2w, this);
				}
				return _isStretch;
			}
			set
			{
				if (_isStretch == value)
				{
					return;
				}
				_isStretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("regionParts")] 
		public CArray<rendTextureRegionPart> RegionParts
		{
			get
			{
				if (_regionParts == null)
				{
					_regionParts = (CArray<rendTextureRegionPart>) CR2WTypeManager.Create("array:rendTextureRegionPart", "regionParts", cr2w, this);
				}
				return _regionParts;
			}
			set
			{
				if (_regionParts == value)
				{
					return;
				}
				_regionParts = value;
				PropertySet(this);
			}
		}

		public rendTextureRegion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
