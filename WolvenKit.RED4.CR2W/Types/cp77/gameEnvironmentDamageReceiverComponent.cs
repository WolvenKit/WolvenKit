using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverComponent : entIPlacedComponent
	{
		private CFloat _cooldown;
		private CArray<CHandle<gameEnvironmentDamageReceiverShape>> _shapes;

		[Ordinal(5)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<gameEnvironmentDamageReceiverShape>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}

		public gameEnvironmentDamageReceiverComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
