using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnprvSpawnDespawnItem : CVariable
	{
		private TweakDBID _recordID;
		private Transform _finalTransform;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("finalTransform")] 
		public Transform FinalTransform
		{
			get => GetProperty(ref _finalTransform);
			set => SetProperty(ref _finalTransform, value);
		}

		public scnprvSpawnDespawnItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
