using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurveResourceSetEntry : RedBaseClass
	{
		private CName _name;
		private CResourceReference<CurveSet> _curveResRef;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("curveResRef")] 
		public CResourceReference<CurveSet> CurveResRef
		{
			get => GetProperty(ref _curveResRef);
			set => SetProperty(ref _curveResRef, value);
		}
	}
}
