using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionCooldownEvent : redEvent
	{
		private CooldownStorageID _storageID;

		[Ordinal(0)] 
		[RED("storageID")] 
		public CooldownStorageID StorageID
		{
			get => GetProperty(ref _storageID);
			set => SetProperty(ref _storageID, value);
		}

		public ActionCooldownEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
