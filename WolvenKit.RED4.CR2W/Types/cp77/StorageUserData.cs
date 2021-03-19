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
			get => GetProperty(ref _storageObject);
			set => SetProperty(ref _storageObject, value);
		}

		public StorageUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
