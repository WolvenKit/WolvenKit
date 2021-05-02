using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		private CHandle<gamemappinsIPointOfInterestVariant> _typedVariant;
		private CBool _active;

		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get => GetProperty(ref _typedVariant);
			set => SetProperty(ref _typedVariant, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public gamemappinsPointOfInterestMappinData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
