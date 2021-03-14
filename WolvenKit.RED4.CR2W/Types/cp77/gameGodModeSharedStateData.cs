using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSharedStateData : CVariable
	{
		private wCHandle<entEntity> _entity;
		private CInt32 _flags;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CInt32) CR2WTypeManager.Create("Int32", "flags", cr2w, this);
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

		public gameGodModeSharedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
