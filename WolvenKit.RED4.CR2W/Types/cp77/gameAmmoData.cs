using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAmmoData : CVariable
	{
		private gameItemID _id;
		private CInt32 _available;
		private CInt32 _equipped;

		[Ordinal(0)] 
		[RED("id")] 
		public gameItemID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gameItemID) CR2WTypeManager.Create("gameItemID", "id", cr2w, this);
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

		[Ordinal(1)] 
		[RED("available")] 
		public CInt32 Available
		{
			get
			{
				if (_available == null)
				{
					_available = (CInt32) CR2WTypeManager.Create("Int32", "available", cr2w, this);
				}
				return _available;
			}
			set
			{
				if (_available == value)
				{
					return;
				}
				_available = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipped")] 
		public CInt32 Equipped
		{
			get
			{
				if (_equipped == null)
				{
					_equipped = (CInt32) CR2WTypeManager.Create("Int32", "equipped", cr2w, this);
				}
				return _equipped;
			}
			set
			{
				if (_equipped == value)
				{
					return;
				}
				_equipped = value;
				PropertySet(this);
			}
		}

		public gameAmmoData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
