using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netIEntityState : CVariable
	{
		private TweakDBID _recordID;
		private CUInt64 _persistentID;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("persistentID")] 
		public CUInt64 PersistentID
		{
			get => GetProperty(ref _persistentID);
			set => SetProperty(ref _persistentID, value);
		}

		public netIEntityState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
