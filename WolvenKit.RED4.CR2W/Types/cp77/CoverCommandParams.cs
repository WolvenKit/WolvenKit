using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverCommandParams : IScriptable
	{
		private CArray<CEnum<AICoverExposureMethod>> _exposureMethods;

		[Ordinal(0)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get => GetProperty(ref _exposureMethods);
			set => SetProperty(ref _exposureMethods, value);
		}

		public CoverCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
