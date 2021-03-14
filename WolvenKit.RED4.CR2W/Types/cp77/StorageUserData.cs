using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StorageUserData : IScriptable
	{
		private wCHandle<gameObject> _storageObject;

		[Ordinal(0)] 
		[RED("storageObject")] 
		public wCHandle<gameObject> StorageObject
		{
			get
			{
				if (_storageObject == null)
				{
					_storageObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "storageObject", cr2w, this);
				}
				return _storageObject;
			}
			set
			{
				if (_storageObject == value)
				{
					return;
				}
				_storageObject = value;
				PropertySet(this);
			}
		}

		public StorageUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
