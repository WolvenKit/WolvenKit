using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDatabaseCollectionEntry : CVariable
	{
		private CName _name;
		private rRef<C2dArray> _animDatabase;
		private rRef<animGenericAnimDatabase> _overrideAnimDatabase;

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
		[RED("animDatabase")] 
		public rRef<C2dArray> AnimDatabase
		{
			get
			{
				if (_animDatabase == null)
				{
					_animDatabase = (rRef<C2dArray>) CR2WTypeManager.Create("rRef:C2dArray", "animDatabase", cr2w, this);
				}
				return _animDatabase;
			}
			set
			{
				if (_animDatabase == value)
				{
					return;
				}
				_animDatabase = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrideAnimDatabase")] 
		public rRef<animGenericAnimDatabase> OverrideAnimDatabase
		{
			get
			{
				if (_overrideAnimDatabase == null)
				{
					_overrideAnimDatabase = (rRef<animGenericAnimDatabase>) CR2WTypeManager.Create("rRef:animGenericAnimDatabase", "overrideAnimDatabase", cr2w, this);
				}
				return _overrideAnimDatabase;
			}
			set
			{
				if (_overrideAnimDatabase == value)
				{
					return;
				}
				_overrideAnimDatabase = value;
				PropertySet(this);
			}
		}

		public animAnimDatabaseCollectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
