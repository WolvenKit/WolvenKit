using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecheatsystemObjCheats : CVariable
	{
		private wCHandle<gameObject> _object;
		private CInt32 _flags;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
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

		public gamecheatsystemObjCheats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
