using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		private CName _itemTweakDBString;

		[Ordinal(120)] 
		[RED("itemTweakDBString")] 
		public CName ItemTweakDBString
		{
			get => GetProperty(ref _itemTweakDBString);
			set => SetProperty(ref _itemTweakDBString, value);
		}

		public C4ControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
