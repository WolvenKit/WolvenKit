using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NoAmmoDecisions : WeaponTransition
	{
		private CHandle<redCallbackObject> _callbackID;

		[Ordinal(3)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		public NoAmmoDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
