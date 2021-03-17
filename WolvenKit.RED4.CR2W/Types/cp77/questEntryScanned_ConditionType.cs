using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntryScanned_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private TweakDBID _entryID;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public TweakDBID EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public questEntryScanned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
