using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JunkItemRecord : CVariable
	{
		private TweakDBID _junkItemID;

		[Ordinal(0)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get => GetProperty(ref _junkItemID);
			set => SetProperty(ref _junkItemID, value);
		}

		public JunkItemRecord(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
