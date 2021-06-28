using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entHitRepresentationDataParameter : entEntityParameter
	{
		private CArray<gameHitRepresentationOverride> _hitRepresentationOverrides;

		[Ordinal(0)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get => GetProperty(ref _hitRepresentationOverrides);
			set => SetProperty(ref _hitRepresentationOverrides, value);
		}

		public entHitRepresentationDataParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
