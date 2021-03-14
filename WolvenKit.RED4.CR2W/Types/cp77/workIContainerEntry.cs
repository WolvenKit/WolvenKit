using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIContainerEntry : workIEntry
	{
		private CArray<CHandle<workIEntry>> _list;
		private CName _idleAnim;

		[Ordinal(2)] 
		[RED("list")] 
		public CArray<CHandle<workIEntry>> List
		{
			get
			{
				if (_list == null)
				{
					_list = (CArray<CHandle<workIEntry>>) CR2WTypeManager.Create("array:handle:workIEntry", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get
			{
				if (_idleAnim == null)
				{
					_idleAnim = (CName) CR2WTypeManager.Create("CName", "idleAnim", cr2w, this);
				}
				return _idleAnim;
			}
			set
			{
				if (_idleAnim == value)
				{
					return;
				}
				_idleAnim = value;
				PropertySet(this);
			}
		}

		public workIContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
