using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SemiAutoDecisions : WeaponTransition
	{
		private CHandle<redCallbackObject> _callBackID;

		[Ordinal(3)] 
		[RED("callBackID")] 
		public CHandle<redCallbackObject> CallBackID
		{
			get => GetProperty(ref _callBackID);
			set => SetProperty(ref _callBackID, value);
		}

		public SemiAutoDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
