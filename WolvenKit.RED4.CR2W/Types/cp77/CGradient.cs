using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CGradient : CResource
	{
		private CArray<rendGradientEntry> _gradientEntries;

		[Ordinal(1)] 
		[RED("gradientEntries")] 
		public CArray<rendGradientEntry> GradientEntries
		{
			get => GetProperty(ref _gradientEntries);
			set => SetProperty(ref _gradientEntries, value);
		}

		public CGradient(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
