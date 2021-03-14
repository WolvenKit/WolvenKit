using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestComponentPS : gameComponentPS
	{
		private CInt32 _something;
		private CBool _somethingNotInstanceEdiable;
		private CName _nameEditable;
		private CName _nameInstanceEditable;
		private CName _namePersistent;
		private CName _namePersistentEdiable;
		private CName _namePersistentInstanceEditable;

		[Ordinal(0)] 
		[RED("something")] 
		public CInt32 Something
		{
			get
			{
				if (_something == null)
				{
					_something = (CInt32) CR2WTypeManager.Create("Int32", "something", cr2w, this);
				}
				return _something;
			}
			set
			{
				if (_something == value)
				{
					return;
				}
				_something = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("somethingNotInstanceEdiable")] 
		public CBool SomethingNotInstanceEdiable
		{
			get
			{
				if (_somethingNotInstanceEdiable == null)
				{
					_somethingNotInstanceEdiable = (CBool) CR2WTypeManager.Create("Bool", "somethingNotInstanceEdiable", cr2w, this);
				}
				return _somethingNotInstanceEdiable;
			}
			set
			{
				if (_somethingNotInstanceEdiable == value)
				{
					return;
				}
				_somethingNotInstanceEdiable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nameEditable")] 
		public CName NameEditable
		{
			get
			{
				if (_nameEditable == null)
				{
					_nameEditable = (CName) CR2WTypeManager.Create("CName", "nameEditable", cr2w, this);
				}
				return _nameEditable;
			}
			set
			{
				if (_nameEditable == value)
				{
					return;
				}
				_nameEditable = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nameInstanceEditable")] 
		public CName NameInstanceEditable
		{
			get
			{
				if (_nameInstanceEditable == null)
				{
					_nameInstanceEditable = (CName) CR2WTypeManager.Create("CName", "nameInstanceEditable", cr2w, this);
				}
				return _nameInstanceEditable;
			}
			set
			{
				if (_nameInstanceEditable == value)
				{
					return;
				}
				_nameInstanceEditable = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("namePersistent")] 
		public CName NamePersistent
		{
			get
			{
				if (_namePersistent == null)
				{
					_namePersistent = (CName) CR2WTypeManager.Create("CName", "namePersistent", cr2w, this);
				}
				return _namePersistent;
			}
			set
			{
				if (_namePersistent == value)
				{
					return;
				}
				_namePersistent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("namePersistentEdiable")] 
		public CName NamePersistentEdiable
		{
			get
			{
				if (_namePersistentEdiable == null)
				{
					_namePersistentEdiable = (CName) CR2WTypeManager.Create("CName", "namePersistentEdiable", cr2w, this);
				}
				return _namePersistentEdiable;
			}
			set
			{
				if (_namePersistentEdiable == value)
				{
					return;
				}
				_namePersistentEdiable = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("namePersistentInstanceEditable")] 
		public CName NamePersistentInstanceEditable
		{
			get
			{
				if (_namePersistentInstanceEditable == null)
				{
					_namePersistentInstanceEditable = (CName) CR2WTypeManager.Create("CName", "namePersistentInstanceEditable", cr2w, this);
				}
				return _namePersistentInstanceEditable;
			}
			set
			{
				if (_namePersistentInstanceEditable == value)
				{
					return;
				}
				_namePersistentInstanceEditable = value;
				PropertySet(this);
			}
		}

		public cpTestComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
