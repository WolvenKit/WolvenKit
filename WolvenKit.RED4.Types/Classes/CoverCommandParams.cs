using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoverCommandParams : IScriptable
	{
		private CArray<CEnum<AICoverExposureMethod>> _exposureMethods;

		[Ordinal(0)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get => GetProperty(ref _exposureMethods);
			set => SetProperty(ref _exposureMethods, value);
		}
	}
}
