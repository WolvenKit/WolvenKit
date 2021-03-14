using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCustomFilterData : ISerializable
	{
		private CArray<CName> _collisionType;
		private CArray<CName> _collideWith;
		private CArray<CName> _queryDetect;

		[Ordinal(0)] 
		[RED("collisionType")] 
		public CArray<CName> CollisionType
		{
			get
			{
				if (_collisionType == null)
				{
					_collisionType = (CArray<CName>) CR2WTypeManager.Create("array:CName", "collisionType", cr2w, this);
				}
				return _collisionType;
			}
			set
			{
				if (_collisionType == value)
				{
					return;
				}
				_collisionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("collideWith")] 
		public CArray<CName> CollideWith
		{
			get
			{
				if (_collideWith == null)
				{
					_collideWith = (CArray<CName>) CR2WTypeManager.Create("array:CName", "collideWith", cr2w, this);
				}
				return _collideWith;
			}
			set
			{
				if (_collideWith == value)
				{
					return;
				}
				_collideWith = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("queryDetect")] 
		public CArray<CName> QueryDetect
		{
			get
			{
				if (_queryDetect == null)
				{
					_queryDetect = (CArray<CName>) CR2WTypeManager.Create("array:CName", "queryDetect", cr2w, this);
				}
				return _queryDetect;
			}
			set
			{
				if (_queryDetect == value)
				{
					return;
				}
				_queryDetect = value;
				PropertySet(this);
			}
		}

		public physicsCustomFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
